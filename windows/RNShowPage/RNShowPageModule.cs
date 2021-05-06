using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Show.Page.RNShowPage
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNShowPageModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNShowPageModule"/>.
        /// </summary>
        internal RNShowPageModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNShowPage";
            }
        }
    }
}
