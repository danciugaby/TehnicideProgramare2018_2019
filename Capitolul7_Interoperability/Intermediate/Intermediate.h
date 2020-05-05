// Intermediate.h
#pragma once
#include <opencv2/core.hpp>
#include <opencv2/imgproc.hpp>
#include <opencv2/highgui.hpp>
#include "../CoreProject/Processer.h"

#pragma region namespaces
using namespace System;
using namespace System::Drawing;
using namespace System::Drawing::Imaging;
using namespace System::Runtime::InteropServices;
using namespace System::Windows;
using namespace System::Windows::Interop;
using namespace System::Windows::Media::Imaging;
#pragma endregion

#pragma region API Import
[DllImportAttribute("gdi32.dll")]
extern bool DeleteObject(IntPtr handle);
#pragma endregion

namespace Intermediate {
	
	public ref class Mapper
	{
	public:
		static char* MapToCPPArrayChar(String^ imagePath);
		static BitmapSource^ ToBitmapSource(cv::Mat image);	
		static BitmapSource^ ProcessImage(String^ path);	
		static BitmapSource^ ProcessAndSaveImage(String^ path, String^ pathtosave);
		static array<System::Byte>^ ToByteArray(cv::Mat image);
	};
}
