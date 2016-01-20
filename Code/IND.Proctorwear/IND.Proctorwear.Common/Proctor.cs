using System;
using libpxcclr.cs;

namespace IND.Proctorwear.Common
{
    public class Proctor : IDisposable
    {
        #region Fields
        PXCMSenseManager senseManager;
        PXCMSenseManager.Handler sensed;
        #endregion

        #region Constructors
        public Proctor()
        {
            Initialize();
        }
        #endregion

        #region Private methods
        private void Initialize()
        {
            senseManager = PXCMSenseManager.CreateInstance();
            senseManager.EnableStream(PXCMCapture.StreamType.STREAM_TYPE_COLOR, 320, 240, 30);
            sensed = new PXCMSenseManager.Handler();
            sensed.onNewSample += OnNewSample;
            senseManager.Init(sensed);
        }

        #endregion

        #region Public methods
        /// <summary>
        /// Starts proctoring
        /// </summary>
        public void Start()
        {
            senseManager.StreamFrames(false);
        }
        #endregion

        #region Event handlers
        private pxcmStatus OnNewSample(int mid, PXCMCapture.Sample sample)
        {
            return pxcmStatus.PXCM_STATUS_NO_ERROR;
        }

        public void Dispose()
        {
            senseManager.Dispose();
        }

        #endregion
    }
}
