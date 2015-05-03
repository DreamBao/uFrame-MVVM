// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrame.DefaultProject {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.DefaultProject;
    
    
    public class MainMenuSystemLoaderBase : SystemLoader {
        
        private MainMenuScreenViewModel _MainMenuScreen;
        
        private MainMenuScreenController _MainMenuScreenController;
        
        [InjectAttribute("MainMenuScreen")]
        public virtual MainMenuScreenViewModel MainMenuScreen {
            get {
                if (this._MainMenuScreen == null) {
                    this._MainMenuScreen = CreateInstanceViewModel<MainMenuScreenViewModel>( "MainMenuScreen");
                }
                return _MainMenuScreen;
            }
            set {
            }
        }
        
        [InjectAttribute()]
        public virtual MainMenuScreenController MainMenuScreenController {
            get {
                if (_MainMenuScreenController==null) {
                    _MainMenuScreenController = Container.CreateInstance(typeof(MainMenuScreenController)) as MainMenuScreenController;;
                }
                return _MainMenuScreenController;
            }
            set {
                _MainMenuScreenController = value;
            }
        }
        
        public override void Load() {
            Container.RegisterViewModelManager<MainMenuScreenViewModel>(new ViewModelManager<MainMenuScreenViewModel>());
            Container.RegisterController<MainMenuScreenController>(MainMenuScreenController);
            Container.RegisterViewModel<MainMenuScreenViewModel>(MainMenuScreen, "MainMenuScreen");
        }
    }
}
