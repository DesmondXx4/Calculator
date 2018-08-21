#pragma once
#include <iostream>
#include <iomanip>
using namespace std;

class Shape
{
public:
	virtual void type() const = 0;
	virtual void length() const = 0;
	virtual double area() const = 0;
};

class Square : public Shape
{
	double sideLength;
public:
	void setup(double sl) { sideLength = sl; }
	virtual void type() const
	{
		cout << "图形类型：正方形" << endl;
	}
	virtual void length() const
	{
		cout << "边长：" << setiosflags(ios::fixed) << setprecision(3) << sideLength << "cm" << endl;
	}
	virtual double area() const
	{
		return sideLength * sideLength;
	}
};

class Rectangle :public Shape
{
	double Length, Width;
public:
	void setup(double l, double w) { Length = l; Width = w; }
	virtual void type() const
	{
		cout << "图形类型: 长方形" << endl;
	}
	virtual void length() const
	{
		cout << "长为：" << setiosflags(ios::fixed) << setprecision(3) << Length << "cm" << "宽为：" << Width << "cm" << endl;
	}
	virtual double area() const
	{
		return Length * Width;
	}

};

class Triangle : public Shape
{
	double bottom;
	double height;
public:
	void setup(double bt, double ht) { bottom = bt; height = ht; }
	virtual void type() const
	{
		cout << "图形类型: 三角形" << endl;
	}
	virtual void length() const
	{
		cout << "底为：" << setiosflags(ios::fixed) << setprecision(3) << bottom << "cm" << "," << "高为：" << height << "cm" << endl;
	}
	virtual double area() const
	{
		return 0.5*bottom*height;
	}
};

class Round : public Shape
{
	double Radius;
public:
	void setup(double r) { Radius = r; }
	virtual void type() const
	{
		cout << "图形类型: 圆形" << endl;
	}
	virtual void length() const
	{
		cout << "半径为：" << setiosflags(ios::fixed) << setprecision(3) << Radius << "cm" << endl;
	}
	virtual double area() const
	{
		return 3.14*Radius*Radius;
	}
};