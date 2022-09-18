using Castle.MicroKernel.Registration;
using Castle.Windsor;
using FigureAreaCalc.Lib.Service;

namespace FigureAreaCalc.Tests;

public abstract class FigureAreaCalcTestBase
{
    private static IWindsorContainer _iocContainer;

    protected IWindsorContainer IocContainer
    {
        get
        {
            if (_iocContainer == null)
            {
                _iocContainer = new WindsorContainer();
                RegisterServices();
            }

            return _iocContainer;
        }
    }

    private static void RegisterServices()
    {
        _iocContainer.Register(Component.For<ICalcService, CalcService>());
    }

    protected TService Resolve<TService>() => IocContainer.Resolve<TService>();
}