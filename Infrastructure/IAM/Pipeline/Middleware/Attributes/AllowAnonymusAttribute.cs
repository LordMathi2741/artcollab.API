namespace Infrastructure.IAM.Pipeline.Middleware.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class AllowAnonymousAttribute : Attribute { }