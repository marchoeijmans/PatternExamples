using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPattern
{
    public class Presenter
    {
        private IView viewToControl;
        private Model model;
        private PresentationModel presentationModel;

        public Presenter(IView view, Model model)
        {
            this.viewToControl = view;
            this.model = model;

            PresentationModelAdapter adapter = new PresentationModelAdapter(this.model);
            this.presentationModel = adapter.PresentationModel;
        }

        public void InitializePresenter()
        {
            this.model.Naam = "Marc";
            this.model.Leeftijd = 42;
            this.PresenterInitialized();
        }

        public void PresenterInitialized()
        {
            this.viewToControl.PresenterInitializeComplete(this.presentationModel);
        }

        public void UpdateLeeftijd(Model model)
        {
            this.model = model;

            this.model.Leeftijd++;
            this.viewToControl.UpgradeComplete(this.presentationModel);
        }
    }
}