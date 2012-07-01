using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPattern
{
    public interface IView
    {
        void PresenterInitializeComplete(PresentationModel model);

        void UpgradeComplete(PresentationModel model);
    }
}