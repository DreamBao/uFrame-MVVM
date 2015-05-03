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
    using UniRx;
    using UnityEngine;
    
    
    public class MainMenuScreenViewBase : ViewBase {
        
        [UFToggleGroup("PlayGame")]
        [UnityEngine.HideInInspector()]
        public bool _BindPlayGame = true;
        
        [UFGroup("PlayGame")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_PlayGamebutton")]
        protected UnityEngine.UI.Button _PlayGameButton;
        
        public override string DefaultIdentifier {
            get {
                return "MainMenuScreen";
            }
        }
        
        public override System.Type ViewModelType {
            get {
                return typeof(MainMenuScreenViewModel);
            }
        }
        
        public MainMenuScreenViewModel MainMenuScreen {
            get {
                return (MainMenuScreenViewModel)ViewModelObject;
            }
        }
        
        protected override void InitializeViewModel(ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as MainMenuScreenViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.MainMenuScreen to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
            if (_BindPlayGame) {
                this.BindButtonToCommand(_PlayGameButton, this.MainMenuScreen.PlayGame);
            }
        }
        
        public virtual void ExecutePlayGame() {
            MainMenuScreen.PlayGame.OnNext(new PlayGameCommand() { Sender = MainMenuScreen });
        }
        
        public virtual void ExecutePlayGame(PlayGameCommand command) {
            command.Sender = MainMenuScreen;
            MainMenuScreen.PlayGame.OnNext(command);
        }
    }
}
