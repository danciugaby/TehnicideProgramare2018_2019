#pragma once
#include <opencv2/core.hpp>
#include <opencv2/imgproc.hpp>
#include <opencv2/highgui.hpp>

#define MINSIZE 10
class Contours
{
public:
	Contours(void);
	~Contours(void);
	cv::Mat computeEdges(cv::Mat & original)
	{
		cv::Mat gray;
		cv::cvtColor(original, gray, CV_BGR2GRAY);
		cv::Scalar meanvalue, stdvalue;
		cv::meanStdDev(gray,meanvalue, stdvalue);
		double t1=meanvalue.val[0]/3.0;
		double t2=meanvalue.val[0];

		cv::Canny(gray,gray,t1,t2);
		cv::namedWindow("canny",0);
		cv::imshow("canny",gray);
		cv::waitKey();
		cv::Mat colored;
		cv::cvtColor(gray,colored,CV_GRAY2BGR);
		return colored;
	};

	cv::Mat computeContours(cv::Mat & original)
	{
		cv::Mat gray, colored;
		cv::cvtColor(original, gray, CV_BGR2GRAY);
		cv::Scalar meanvalue, stdvalue;
		cv::meanStdDev(gray,meanvalue, stdvalue);
		double t1=meanvalue.val[0]/3.0;
		double t2=meanvalue.val[0];

		cv::Canny(gray,gray,t1,t2);
		
		std::vector<std::vector <cv::Point> > contours;
		colored = original.clone();
		colored = cv::Scalar(0,0,0);
		cv::dilate(gray,gray,cv::Mat());
		cv::namedWindow("test",0);
		cv::imshow("test",gray);
		cv::waitKey();

		cv::findContours(gray,contours,CV_RETR_CCOMP, CV_CHAIN_APPROX_NONE);

		cv::Mat mask(gray.rows,gray.cols,gray.type(), cv::Scalar(0));

		for(int i=0;i<contours.size();i++)
		{
			cv::Rect r = cv::boundingRect(contours[i]);
			if (r.width < MINSIZE || r.height < MINSIZE )
				continue;
			cv::Scalar color =  cv::Scalar(rand()&255,rand()&255,rand()&255 );
			
			cv::RotatedRect rr = cv::minAreaRect(contours[i]);
			if (rr.size.width > gray.cols || rr.size.height > gray.rows )
				continue;
			cv::ellipse(colored, rr,color,1);
			double area = cv::contourArea(contours[i]);
			char text[256];
			sprintf(text,"%3.2lf", area);
			cv::putText(colored, text,rr.center,CV_FONT_HERSHEY_PLAIN,1,color,2);
			/*mask = cv::Scalar(0);
			cv::drawContours(mask,contours,i,color,-1);
			cv::namedWindow("mask",0);
			cv::imshow("mask",mask);
			cv::waitKey();*/
			
		}
		return colored;
	}
};

