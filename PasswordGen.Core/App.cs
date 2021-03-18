using MvvmCross.ViewModels;
using PasswordGen.Core.ModelView;

namespace PasswordGen.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<PasswordViewModel>();
        }
    }
}
