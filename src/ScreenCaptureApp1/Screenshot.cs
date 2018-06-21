using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.AllJoyn;
using Windows.Graphics;
using Windows.Graphics.Capture;
using Windows.Graphics.DirectX;
using Windows.Storage;
using Windows.UI;
using Microsoft.Graphics.Canvas;

namespace ScreenCaptureApp1
{
    public class Screenshot
    {







        //private CanvasBitmap _screenshotBitmap;
        //private GraphicsCaptureItem _item;
        //private Direct3D11CaptureFramePool _framePool;
        //private readonly CanvasDevice _canvasDevice;
        //private GraphicsCaptureSession _session;
        //private TaskCompletionSource<bool> _screenshotTaken;
        

        //public Screenshot()
        //{
        //    _canvasDevice = CanvasDevice.GetSharedDevice();
        //}

        //public async Task TakeAsync()
        //{
        //    if (_item == null)
        //         return;

        //    _screenshotTaken = new TaskCompletionSource<bool>();
          
        //    _framePool.FrameArrived += (sender, args) =>
        //    {
        //        using (var frame = _framePool.TryGetNextFrame())
        //        {
        //            _screenshotBitmap = CanvasBitmap.CreateFromDirect3D11Surface(_canvasDevice, frame.Surface);
        //        }
        //        _framePool.Dispose();
        //    };

        //    CreateAndStartCaptureSession(_framePool);
        //    await _screenshotTaken.Task;
        //    StopCapture();
        //}

        //public async Task PickItemAsync()
        //{
        //    var picker = new GraphicsCapturePicker();
        //    _item = await picker.PickSingleItemAsync();

        //    if (_item != null)
        //        _framePool = CreateFramePool(_canvasDevice);

        //}

        //public async Task<StorageFile> SaveToFile(StorageFolder folder, string fileName)
        //{
        //    CanvasRenderTarget offscreen = new CanvasRenderTarget(CanvasDevice.GetSharedDevice(), _screenshotBitmap.SizeInPixels.Width, _screenshotBitmap.SizeInPixels.Height, 96);

        //    using (CanvasDrawingSession ds = offscreen.CreateDrawingSession())
        //    {
        //        ds.Clear(Colors.White);
        //        ds.DrawImage(_screenshotBitmap);
        //    }
            
        //    var newFile = await folder.CreateFileAsync($"{fileName}.png", CreationCollisionOption.ReplaceExisting);
        //    if (newFile != null)
        //        await offscreen.SaveAsync(newFile.Path);

        //    return newFile;
        //}

        //private Direct3D11CaptureFramePool CreateFramePool(CanvasDevice canvasDevice)
        //{
        //    return  Direct3D11CaptureFramePool.Create(
        //        canvasDevice, // D3D device 
        //        DirectXPixelFormat.B8G8R8A8UIntNormalized, // Pixel format 
        //        1, // Number of frames 
        //        _item.Size); // Size of the buffers 
        //}

        //private void CreateAndStartCaptureSession(Direct3D11CaptureFramePool framePool)
        //{
        //    _session = framePool.CreateCaptureSession(_item);
        //    _session.StartCapture();
        //}

        //public void StopCapture()
        //{
        //    _session?.Dispose();
        //    //_framePool?.Dispose();
        //    _item = null;
        //    _session = null;
        //    //_framePool = null;
        //    _screenshotTaken = null;
        //}


    }
}
