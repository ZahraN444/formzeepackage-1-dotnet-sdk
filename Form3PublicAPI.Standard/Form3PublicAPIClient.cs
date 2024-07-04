// <copyright file="Form3PublicAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using Form3PublicAPI.Standard.Authentication;
    using Form3PublicAPI.Standard.Controllers;
    using Form3PublicAPI.Standard.Http.Client;
    using Form3PublicAPI.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class Form3PublicAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api.form3.tech/v1" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly Lazy<AuditController> audit;
        private readonly Lazy<SchemeFileAPIController> schemeFileAPI;
        private readonly Lazy<TransactionFileAPIController> transactionFileAPI;
        private readonly Lazy<MetricsAPIController> metricsAPI;
        private readonly Lazy<ReportsController> reports;
        private readonly Lazy<SchemeMessagesController> schemeMessages;
        private readonly Lazy<SubscriptionsController> subscriptions;
        private readonly Lazy<Oauth2Controller> oauth2;
        private readonly Lazy<AccountsController> accounts;
        private readonly Lazy<AccountIdentificationController> accountIdentification;
        private readonly Lazy<BranchesController> branches;
        private readonly Lazy<BranchIdentificationController> branchIdentification;
        private readonly Lazy<NameVerificationAPIController> nameVerificationAPI;
        private readonly Lazy<PaymentsController> payments;
        private readonly Lazy<OrganisationsController> organisations;
        private readonly Lazy<PlatformsecurityapiController> platformsecurityapi;
        private readonly Lazy<RolesController> roles;
        private readonly Lazy<ACEController> aCE;
        private readonly Lazy<UsersController> users;
        private readonly Lazy<ClaimsController> claims;
        private readonly Lazy<DirectDebitsController> directDebits;
        private readonly Lazy<MandatesController> mandates;
        private readonly Lazy<QueryApiController> queryApi;
        private readonly Lazy<AccountValidationController> accountValidation;
        private readonly Lazy<OAuthAuthorizationController> oAuthAuthorization;

        private Form3PublicAPIClient(
            Environment environment,
            BasicModel basicModel,
            OAuth2Model oAuth2Model,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.HttpClientConfiguration = httpClientConfiguration;
            BasicModel = basicModel;
            var basicManager = new BasicManager(basicModel);
            OAuth2Model = oAuth2Model;
            var oAuth2Manager = new OAuth2Manager(oAuth2Model);
            oAuth2Manager.ApplyGlobalConfiguration(() => OAuthAuthorizationController);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"Basic", basicManager},
                    {"OAuth2", oAuth2Manager},
                })
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();

            BasicCredentials = basicManager;
            OAuth2Credentials = oAuth2Manager;

            this.audit = new Lazy<AuditController>(
                () => new AuditController(globalConfiguration));
            this.schemeFileAPI = new Lazy<SchemeFileAPIController>(
                () => new SchemeFileAPIController(globalConfiguration));
            this.transactionFileAPI = new Lazy<TransactionFileAPIController>(
                () => new TransactionFileAPIController(globalConfiguration));
            this.metricsAPI = new Lazy<MetricsAPIController>(
                () => new MetricsAPIController(globalConfiguration));
            this.reports = new Lazy<ReportsController>(
                () => new ReportsController(globalConfiguration));
            this.schemeMessages = new Lazy<SchemeMessagesController>(
                () => new SchemeMessagesController(globalConfiguration));
            this.subscriptions = new Lazy<SubscriptionsController>(
                () => new SubscriptionsController(globalConfiguration));
            this.oauth2 = new Lazy<Oauth2Controller>(
                () => new Oauth2Controller(globalConfiguration));
            this.accounts = new Lazy<AccountsController>(
                () => new AccountsController(globalConfiguration));
            this.accountIdentification = new Lazy<AccountIdentificationController>(
                () => new AccountIdentificationController(globalConfiguration));
            this.branches = new Lazy<BranchesController>(
                () => new BranchesController(globalConfiguration));
            this.branchIdentification = new Lazy<BranchIdentificationController>(
                () => new BranchIdentificationController(globalConfiguration));
            this.nameVerificationAPI = new Lazy<NameVerificationAPIController>(
                () => new NameVerificationAPIController(globalConfiguration));
            this.payments = new Lazy<PaymentsController>(
                () => new PaymentsController(globalConfiguration));
            this.organisations = new Lazy<OrganisationsController>(
                () => new OrganisationsController(globalConfiguration));
            this.platformsecurityapi = new Lazy<PlatformsecurityapiController>(
                () => new PlatformsecurityapiController(globalConfiguration));
            this.roles = new Lazy<RolesController>(
                () => new RolesController(globalConfiguration));
            this.aCE = new Lazy<ACEController>(
                () => new ACEController(globalConfiguration));
            this.users = new Lazy<UsersController>(
                () => new UsersController(globalConfiguration));
            this.claims = new Lazy<ClaimsController>(
                () => new ClaimsController(globalConfiguration));
            this.directDebits = new Lazy<DirectDebitsController>(
                () => new DirectDebitsController(globalConfiguration));
            this.mandates = new Lazy<MandatesController>(
                () => new MandatesController(globalConfiguration));
            this.queryApi = new Lazy<QueryApiController>(
                () => new QueryApiController(globalConfiguration));
            this.accountValidation = new Lazy<AccountValidationController>(
                () => new AccountValidationController(globalConfiguration));
            this.oAuthAuthorization = new Lazy<OAuthAuthorizationController>(
                () => new OAuthAuthorizationController(globalConfiguration));
        }

        /// <summary>
        /// Gets AuditController controller.
        /// </summary>
        public AuditController AuditController => this.audit.Value;

        /// <summary>
        /// Gets SchemeFileAPIController controller.
        /// </summary>
        public SchemeFileAPIController SchemeFileAPIController => this.schemeFileAPI.Value;

        /// <summary>
        /// Gets TransactionFileAPIController controller.
        /// </summary>
        public TransactionFileAPIController TransactionFileAPIController => this.transactionFileAPI.Value;

        /// <summary>
        /// Gets MetricsAPIController controller.
        /// </summary>
        public MetricsAPIController MetricsAPIController => this.metricsAPI.Value;

        /// <summary>
        /// Gets ReportsController controller.
        /// </summary>
        public ReportsController ReportsController => this.reports.Value;

        /// <summary>
        /// Gets SchemeMessagesController controller.
        /// </summary>
        public SchemeMessagesController SchemeMessagesController => this.schemeMessages.Value;

        /// <summary>
        /// Gets SubscriptionsController controller.
        /// </summary>
        public SubscriptionsController SubscriptionsController => this.subscriptions.Value;

        /// <summary>
        /// Gets Oauth2Controller controller.
        /// </summary>
        public Oauth2Controller Oauth2Controller => this.oauth2.Value;

        /// <summary>
        /// Gets AccountsController controller.
        /// </summary>
        public AccountsController AccountsController => this.accounts.Value;

        /// <summary>
        /// Gets AccountIdentificationController controller.
        /// </summary>
        public AccountIdentificationController AccountIdentificationController => this.accountIdentification.Value;

        /// <summary>
        /// Gets BranchesController controller.
        /// </summary>
        public BranchesController BranchesController => this.branches.Value;

        /// <summary>
        /// Gets BranchIdentificationController controller.
        /// </summary>
        public BranchIdentificationController BranchIdentificationController => this.branchIdentification.Value;

        /// <summary>
        /// Gets NameVerificationAPIController controller.
        /// </summary>
        public NameVerificationAPIController NameVerificationAPIController => this.nameVerificationAPI.Value;

        /// <summary>
        /// Gets PaymentsController controller.
        /// </summary>
        public PaymentsController PaymentsController => this.payments.Value;

        /// <summary>
        /// Gets OrganisationsController controller.
        /// </summary>
        public OrganisationsController OrganisationsController => this.organisations.Value;

        /// <summary>
        /// Gets PlatformsecurityapiController controller.
        /// </summary>
        public PlatformsecurityapiController PlatformsecurityapiController => this.platformsecurityapi.Value;

        /// <summary>
        /// Gets RolesController controller.
        /// </summary>
        public RolesController RolesController => this.roles.Value;

        /// <summary>
        /// Gets ACEController controller.
        /// </summary>
        public ACEController ACEController => this.aCE.Value;

        /// <summary>
        /// Gets UsersController controller.
        /// </summary>
        public UsersController UsersController => this.users.Value;

        /// <summary>
        /// Gets ClaimsController controller.
        /// </summary>
        public ClaimsController ClaimsController => this.claims.Value;

        /// <summary>
        /// Gets DirectDebitsController controller.
        /// </summary>
        public DirectDebitsController DirectDebitsController => this.directDebits.Value;

        /// <summary>
        /// Gets MandatesController controller.
        /// </summary>
        public MandatesController MandatesController => this.mandates.Value;

        /// <summary>
        /// Gets QueryApiController controller.
        /// </summary>
        public QueryApiController QueryApiController => this.queryApi.Value;

        /// <summary>
        /// Gets AccountValidationController controller.
        /// </summary>
        public AccountValidationController AccountValidationController => this.accountValidation.Value;

        /// <summary>
        /// Gets OAuthAuthorizationController controller.
        /// </summary>
        public OAuthAuthorizationController OAuthAuthorizationController => this.oAuthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }


        /// <summary>
        /// Gets the credentials to use with Basic.
        /// </summary>
        public IBasicCredentials BasicCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with Basic.
        /// </summary>
        public BasicModel BasicModel { get; private set; }

        /// <summary>
        /// Gets the credentials to use with OAuth2.
        /// </summary>
        public IOAuth2Credentials OAuth2Credentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with OAuth2.
        /// </summary>
        public OAuth2Model OAuth2Model { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the Form3PublicAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpClientConfig(config => config.Build());

            if (BasicModel != null)
            {
                builder.BasicCredentials(BasicModel.ToBuilder().Build());
            }

            if (OAuth2Model != null)
            {
                builder.OAuth2Credentials(OAuth2Model.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> Form3PublicAPIClient.</returns>
        internal static Form3PublicAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("FORM_3_PUBLIC_API_STANDARD_ENVIRONMENT");
            string username = System.Environment.GetEnvironmentVariable("FORM_3_PUBLIC_API_STANDARD_USERNAME");
            string password = System.Environment.GetEnvironmentVariable("FORM_3_PUBLIC_API_STANDARD_PASSWORD");
            string oAuthClientId = System.Environment.GetEnvironmentVariable("FORM_3_PUBLIC_API_STANDARD_O_AUTH_CLIENT_ID");
            string oAuthClientSecret = System.Environment.GetEnvironmentVariable("FORM_3_PUBLIC_API_STANDARD_O_AUTH_CLIENT_SECRET");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (username != null && password != null)
            {
                builder.BasicCredentials(new BasicModel
                .Builder(username, password)
                .Build());
            }

            if (oAuthClientId != null && oAuthClientSecret != null)
            {
                builder.OAuth2Credentials(new OAuth2Model
                .Builder(oAuthClientId, oAuthClientSecret)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = Form3PublicAPI.Standard.Environment.Production;
            private BasicModel basicModel = new BasicModel();
            private OAuth2Model oAuth2Model = new OAuth2Model();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();

            /// <summary>
            /// Sets credentials for Basic.
            /// </summary>
            /// <param name="basicModel">BasicModel.</param>
            /// <returns>Builder.</returns>
            public Builder BasicCredentials(BasicModel basicModel)
            {
                if (basicModel is null)
                {
                    throw new ArgumentNullException(nameof(basicModel));
                }

                this.basicModel = basicModel;
                return this;
            }

            /// <summary>
            /// Sets credentials for OAuth2.
            /// </summary>
            /// <param name="oAuth2Model">OAuth2Model.</param>
            /// <returns>Builder.</returns>
            public Builder OAuth2Credentials(OAuth2Model oAuth2Model)
            {
                if (oAuth2Model is null)
                {
                    throw new ArgumentNullException(nameof(oAuth2Model));
                }

                this.oAuth2Model = oAuth2Model;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }


           

            /// <summary>
            /// Creates an object of the Form3PublicAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>Form3PublicAPIClient.</returns>
            public Form3PublicAPIClient Build()
            {
                if (basicModel.Username == null || basicModel.Password == null)
                {
                    basicModel = null;
                }
                if (oAuth2Model.OAuthClientId == null || oAuth2Model.OAuthClientSecret == null)
                {
                    oAuth2Model = null;
                }
                return new Form3PublicAPIClient(
                    environment,
                    basicModel,
                    oAuth2Model,
                    httpClientConfig.Build());
            }
        }
    }
}
