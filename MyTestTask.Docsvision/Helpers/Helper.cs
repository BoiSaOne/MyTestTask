using DocsVision.BackOffice.ObjectModel;
using DocsVision.BackOffice.ObjectModel.Mapping;
using DocsVision.BackOffice.ObjectModel.Services;
using DocsVision.Platform.Data.Metadata;
using DocsVision.Platform.ObjectManager;
using DocsVision.Platform.ObjectModel;
using DocsVision.Platform.ObjectModel.Mapping;
using DocsVision.Platform.ObjectModel.Persistence;
using DocsVision.Platform.SystemCards.ObjectModel.Mapping;
using DocsVision.Platform.SystemCards.ObjectModel.Services;
using System.ComponentModel.Design;

namespace MyTestTask.Docsvision.Helpers
{
    /// <summary>
    /// Helper
    /// </summary>
    internal class Helper
    {     
        /// <summary>
        /// Сессия пользователя
        /// </summary>
        public UserSession UserSession { get { return _userSession; } }
        private readonly UserSession _userSession;
     
        /// <summary>
        /// Контекст
        /// </summary>
        public ObjectContext ObjectContext { get { return _objectContext; } }
        private readonly ObjectContext _objectContext;

        /// <summary>
        /// Сервис для работы с документами
        /// </summary>
        public IDocumentService DocumentService { 
            get {
                return _objectContext.GetService<IDocumentService>(); 
            }
        }

        /// <summary>
        /// Инициализация Helper
        /// </summary>
        /// <param name="connectAddress">Адрес подключения</param>
        /// <param name="baseName">Имя базы</param>
        public Helper(string connectAddress, string baseName)
        {
            if (string.IsNullOrEmpty(baseName))
            {
                _userSession = CreateUserSession(connectAddress);
            }
            else
            {
                _userSession = CreateUserSession(connectAddress, baseName);
            }         
            _objectContext = CreateObjectContext(_userSession);
        }

        /// <summary>
        /// Получить сессию пользователя
        /// </summary>
        /// <param name="connectAddress">Адрес подключения</param>
        /// <param name="baseName">Имя базы</param>
        /// <returns>Сессия пользователя</returns>
        private static UserSession CreateUserSession(string connectAddress, string baseName = "DocsVision")
        {
            SessionManager sessionManager = SessionManager.CreateInstance();
            sessionManager.Connect(connectAddress, baseName);
            UserSession userSession = sessionManager.CreateSession();
            return userSession;
        }

        /// <summary>
        /// Получить контекст
        /// </summary>
        /// <param name="userSession">Сессия пользователя</param>
        /// <returns>Контекст</returns>
        private static ObjectContext CreateObjectContext(UserSession userSession)
        {
            var sessionContainer = new ServiceContainer();
            sessionContainer.AddService(typeof(UserSession), userSession);
            var objectContext = new ObjectContext(sessionContainer);

            var mapperFactoryRegistry = objectContext.GetService<IObjectMapperFactoryRegistry>();
            mapperFactoryRegistry.RegisterFactory(typeof(SystemCardsMapperFactory));
            mapperFactoryRegistry.RegisterFactory(typeof(BackOfficeMapperFactory));

            var serviceFactoryRegistry = objectContext.GetService<IServiceFactoryRegistry>();
            serviceFactoryRegistry.RegisterFactory(typeof(BackOfficeServiceFactory));
            serviceFactoryRegistry.RegisterFactory(typeof(SystemCardsServiceFactory));

            objectContext.AddService(DocsVisionObjectFactory.CreatePersistentStore(new SessionProvider(userSession), null));
            IMetadataProvider metadataProvider = DocsVisionObjectFactory.CreateMetadataProvider(userSession);
            objectContext.AddService(DocsVisionObjectFactory.CreateMetadataManager(metadataProvider, userSession));
            objectContext.AddService(metadataProvider);

            return objectContext;
        }
    }
}
