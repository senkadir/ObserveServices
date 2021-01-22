# ObserveServices

You can observe what's happining in dependeny injection collection.

[Nuget package](https://www.nuget.org/packages/ObserveServices.Core)

Feel free to contribute it.

```
{
  "Statistics": {
    "TotalCount": 159,
    "TransientCount": 40,
    "ScopedCount": 4,
    "SingletonCount": 115
  },
  "TransientServices": [
    "Microsoft.Extensions.Options.IOptionsFactory\u00601[TOptions]",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerOptions]",
    "Microsoft.AspNetCore.Hosting.IStartupFilter",
    "Microsoft.AspNetCore.Routing.IInlineConstraintResolver",
    "Microsoft.Extensions.ObjectPool.ObjectPoolProvider",
    "Microsoft.AspNetCore.Routing.Tree.TreeRouteBuilder",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.AspNetCore.Routing.RouteOptions]",
    "Microsoft.AspNetCore.Routing.Matching.DfaMatcherBuilder",
    "Microsoft.AspNetCore.Routing.Matching.DataSourceDependentMatcher\u002BLifetime",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.AspNetCore.Mvc.MvcOptions]",
    "Microsoft.Extensions.Options.IPostConfigureOptions\u00601[Microsoft.AspNetCore.Mvc.MvcOptions]",
    "Microsoft.Extensions.Options.IPostConfigureOptions\u00601[Microsoft.AspNetCore.Mvc.MvcOptions]",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.AspNetCore.Mvc.ApiBehaviorOptions]",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.AspNetCore.Routing.RouteOptions]",
    "Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider",
    "Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider",
    "Microsoft.AspNetCore.Mvc.Abstractions.IActionDescriptorProvider",
    "Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintProvider",
    "Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator",
    "Microsoft.AspNetCore.Mvc.Controllers.IControllerPropertyActivator",
    "Microsoft.AspNetCore.Mvc.Abstractions.IActionInvokerProvider",
    "Microsoft.AspNetCore.Mvc.Filters.RequestSizeLimitFilter",
    "Microsoft.AspNetCore.Mvc.Filters.DisableRequestSizeLimitFilter",
    "Microsoft.AspNetCore.Mvc.Filters.RequestFormLimitsFilter",
    "Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider",
    "Microsoft.AspNetCore.Mvc.Routing.MvcAttributeRouteHandler",
    "Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionProvider",
    "Microsoft.AspNetCore.Authorization.IAuthorizationService",
    "Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider",
    "Microsoft.AspNetCore.Authorization.IAuthorizationHandlerProvider",
    "Microsoft.AspNetCore.Authorization.IAuthorizationEvaluator",
    "Microsoft.AspNetCore.Authorization.IAuthorizationHandlerContextFactory",
    "Microsoft.AspNetCore.Authorization.IAuthorizationHandler",
    "Microsoft.AspNetCore.Authorization.Policy.IPolicyEvaluator",
    "Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider",
    "Microsoft.AspNetCore.Cors.Infrastructure.ICorsService",
    "Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyProvider",
    "Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider",
    "Microsoft.AspNetCore.Mvc.Cors.CorsAuthorizationFilter",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.AspNetCore.Mvc.MvcOptions]"
  ],
  "ScopedServices": [
    "Microsoft.Extensions.Options.IOptionsSnapshot\u00601[TOptions]",
    "Microsoft.AspNetCore.Http.IMiddlewareFactory",
    "Microsoft.AspNetCore.Authentication.IAuthenticationService",
    "Microsoft.AspNetCore.Authentication.IAuthenticationHandlerProvider"
  ],
  "SingletonServices": [
    "Microsoft.Extensions.Hosting.IHostingEnvironment",
    "Microsoft.Extensions.Hosting.IHostEnvironment",
    "Microsoft.Extensions.Hosting.HostBuilderContext",
    "Microsoft.Extensions.Configuration.IConfiguration",
    "Microsoft.Extensions.Hosting.IApplicationLifetime",
    "Microsoft.Extensions.Hosting.IHostApplicationLifetime",
    "Microsoft.Extensions.Hosting.IHostLifetime",
    "Microsoft.Extensions.Hosting.IHost",
    "Microsoft.Extensions.Options.IOptions\u00601[TOptions]",
    "Microsoft.Extensions.Options.IOptionsMonitor\u00601[TOptions]",
    "Microsoft.Extensions.Options.IOptionsMonitorCache\u00601[TOptions]",
    "Microsoft.Extensions.Logging.ILoggerFactory",
    "Microsoft.Extensions.Logging.ILogger\u00601[TCategoryName]",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.Extensions.Logging.LoggerFilterOptions]",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.Extensions.Logging.LoggerFilterOptions]",
    "Microsoft.Extensions.Logging.Configuration.ILoggerProviderConfigurationFactory",
    "Microsoft.Extensions.Logging.Configuration.ILoggerProviderConfiguration\u00601[T]",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.Extensions.Logging.LoggerFilterOptions]",
    "Microsoft.Extensions.Options.IOptionsChangeTokenSource\u00601[Microsoft.Extensions.Logging.LoggerFilterOptions]",
    "Microsoft.Extensions.Logging.Configuration.LoggingConfiguration",
    "Microsoft.Extensions.Logging.ILoggerProvider",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.Extensions.Logging.Console.ConsoleLoggerOptions]",
    "Microsoft.Extensions.Options.IOptionsChangeTokenSource\u00601[Microsoft.Extensions.Logging.Console.ConsoleLoggerOptions]",
    "Microsoft.Extensions.Logging.ILoggerProvider",
    "Microsoft.Extensions.Logging.EventSource.LoggingEventSource",
    "Microsoft.Extensions.Logging.ILoggerProvider",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.Extensions.Logging.LoggerFilterOptions]",
    "Microsoft.Extensions.Options.IOptionsChangeTokenSource\u00601[Microsoft.Extensions.Logging.LoggerFilterOptions]",
    "Microsoft.Extensions.Logging.ILoggerProvider",
    "Microsoft.AspNetCore.Hosting.IWebHostEnvironment",
    "Microsoft.AspNetCore.Hosting.IHostingEnvironment",
    "Microsoft.AspNetCore.Hosting.IApplicationLifetime",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.AspNetCore.Hosting.GenericWebHostServiceOptions]",
    "System.Diagnostics.DiagnosticListener",
    "System.Diagnostics.DiagnosticSource",
    "Microsoft.AspNetCore.Http.IHttpContextFactory",
    "Microsoft.AspNetCore.Hosting.Builder.IApplicationBuilderFactory",
    "Microsoft.AspNetCore.Connections.IConnectionListenerFactory",
    "Microsoft.AspNetCore.Hosting.Server.IServer",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerOptions]",
    "Microsoft.Extensions.Options.IPostConfigureOptions\u00601[Microsoft.AspNetCore.HostFiltering.HostFilteringOptions]",
    "Microsoft.Extensions.Options.IOptionsChangeTokenSource\u00601[Microsoft.AspNetCore.HostFiltering.HostFilteringOptions]",
    "Microsoft.Extensions.ObjectPool.ObjectPool\u00601[Microsoft.AspNetCore.Routing.UriBuildingContext]",
    "Microsoft.AspNetCore.Routing.RoutingMarkerService",
    "Microsoft.AspNetCore.Routing.EndpointDataSource",
    "Microsoft.AspNetCore.Routing.ParameterPolicyFactory",
    "Microsoft.AspNetCore.Routing.Matching.MatcherFactory",
    "Microsoft.AspNetCore.Routing.Internal.DfaGraphWriter",
    "Microsoft.AspNetCore.Routing.Matching.EndpointMetadataComparer",
    "Microsoft.AspNetCore.Routing.LinkGenerator",
    "Microsoft.AspNetCore.Routing.IEndpointAddressScheme\u00601[System.String]",
    "Microsoft.AspNetCore.Routing.IEndpointAddressScheme\u00601[Microsoft.AspNetCore.Routing.RouteValuesAddress]",
    "Microsoft.AspNetCore.Routing.LinkParser",
    "Microsoft.AspNetCore.Routing.Matching.EndpointSelector",
    "Microsoft.AspNetCore.Routing.MatcherPolicy",
    "Microsoft.AspNetCore.Routing.MatcherPolicy",
    "Microsoft.AspNetCore.Routing.Template.TemplateBinderFactory",
    "Microsoft.AspNetCore.Routing.Patterns.RoutePatternTransformer",
    "Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager",
    "Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelFactory",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionSelector",
    "Microsoft.AspNetCore.Mvc.ActionConstraints.ActionConstraintCache",
    "Microsoft.AspNetCore.Routing.MatcherPolicy",
    "Microsoft.AspNetCore.Routing.MatcherPolicy",
    "Microsoft.AspNetCore.Mvc.Controllers.IControllerFactory",
    "Microsoft.AspNetCore.Mvc.Controllers.IControllerFactoryProvider",
    "Microsoft.AspNetCore.Mvc.Controllers.IControllerActivatorProvider",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionInvokerFactory",
    "Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvokerCache",
    "Microsoft.AspNetCore.Mvc.Filters.IFilterProvider",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultTypeMapper",
    "Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider",
    "Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderFactory",
    "Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator",
    "Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ClientValidatorCache",
    "Microsoft.AspNetCore.Mvc.ModelBinding.ParameterBinder",
    "Microsoft.Extensions.DependencyInjection.MvcMarkerService",
    "Microsoft.AspNetCore.Mvc.Infrastructure.ITypeActivatorCache",
    "Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IHttpRequestStreamReaderFactory",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IHttpResponseStreamWriterFactory",
    "System.Buffers.ArrayPool\u00601[System.Byte]",
    "System.Buffers.ArrayPool\u00601[System.Char]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.OutputFormatterSelector",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.ObjectResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.PhysicalFileResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.VirtualFileResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.FileStreamResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.FileContentResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.RedirectResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.LocalRedirectResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.RedirectToActionResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.RedirectToRouteResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.RedirectToPageResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.ContentResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor\u00601[Microsoft.AspNetCore.Mvc.JsonResult]",
    "Microsoft.AspNetCore.Mvc.Infrastructure.IClientErrorFactory",
    "Microsoft.AspNetCore.Mvc.Infrastructure.ProblemDetailsFactory",
    "Microsoft.AspNetCore.Mvc.Routing.MvcRouteHandler",
    "Microsoft.AspNetCore.Mvc.Routing.ControllerActionEndpointDataSource",
    "Microsoft.AspNetCore.Mvc.Routing.ActionEndpointFactory",
    "Microsoft.AspNetCore.Mvc.Routing.DynamicControllerEndpointSelector",
    "Microsoft.AspNetCore.Routing.MatcherPolicy",
    "Microsoft.AspNetCore.Mvc.Filters.MiddlewareFilterConfigurationProvider",
    "Microsoft.AspNetCore.Mvc.Filters.MiddlewareFilterBuilder",
    "Microsoft.AspNetCore.Hosting.IStartupFilter",
    "Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionGroupCollectionProvider",
    "Microsoft.AspNetCore.Authentication.IClaimsTransformation",
    "Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider",
    "Microsoft.AspNetCore.Authorization.Policy.AuthorizationPolicyMarkerService",
    "Microsoft.AspNetCore.Mvc.DataAnnotations.IValidationAttributeAdapterProvider",
    "Microsoft.AspNetCore.Mvc.Formatters.FormatFilter",
    "Microsoft.Extensions.Options.IConfigureOptions\u00601[Microsoft.AspNetCore.Hosting.GenericWebHostServiceOptions]",
    "Microsoft.Extensions.Hosting.IHostedService"
  ]
}
```