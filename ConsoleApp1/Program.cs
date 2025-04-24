using Autofac;
using ConsoleApp1;
using SimpleInjector;


// Autofac IoC
var builder = new ContainerBuilder();

builder.RegisterType<GoldCard>().As<CreditCard>();
builder.RegisterType<PlatinumCard>().Named<CreditCard>("PlatinumCard");

var container = builder.Build();

var service = container.Resolve<CreditCard>();
service.Pay();

var service2 = container.Resolve<CreditCard>("PlatinumCard");
service2.Pay();


// Simple Injector IoC
var ioc = new Container();
ioc.Register<CreditCard, PlatinumCard>();

ioc.Verify();
var service3 = ioc.GetInstance<CreditCard>();
service3.Pay();
