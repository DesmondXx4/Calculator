#include "stdafx.h"
#include "CppUnitTest.h"
#include "C:\Users\chenTT\Documents\Tencent Files\492468870\FileRecv\caculater(C++ver)\caculater(C++ver)\classes.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			// TODO: �ڴ�������Դ���
			Square zfx;
			double l = 5, result = 25;
			zfx.setup(l);
			double real = zfx.area();
			Assert::AreEqual(real, result);
		}
		TEST_METHOD(TestMethod2)
		{
			// TODO: �ڴ�������Դ���
			Rectangle cfx;
			double l = 5,w=4, result = 20;
			cfx.setup(l,w);
			double real = cfx.area();
			Assert::AreEqual(real, result);
		}
		TEST_METHOD(TestMethod3)
		{
			// TODO: �ڴ�������Դ���
			Triangle sjx;
			double b= 5, h=4, result = 10;
			sjx.setup(b,h);
			double real = sjx.area();
			Assert::AreEqual(real, result);
		}
		TEST_METHOD(TestMethod4)
		{
			// TODO: �ڴ�������Դ���
			Round yx;
			double r= 5, result =78.5 ;
			yx.setup(r);
			double real = yx.area();
			Assert::AreEqual(real, result);
		}
		TEST_METHOD(TestMethod5)
		{
			// TODO: �ڴ�������Դ���
			Round circle;
			Round *r;
			r=&circle;
			Assert::IsNotNull(r);
		}
	};
}