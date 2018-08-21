#include "classes.h"

void showType(Shape &s)
{
	s.type();
}

void showLength(Shape &s)
{
	s.length();
}

void showArea(Shape &s)
{
	cout << "ͼ�����Ϊ��" << setiosflags(ios::fixed) << setprecision(3) << s.area() << "��ƽ�����ף�" << endl;
}

int main()
{
	int n;
	cout << "��ѡ��ͼ��ͼ�����ͣ�" << endl;
	cout << "1 �����Σ�2 �����Σ�3 �����Σ�4 Բ�Σ�" << endl;
	cin >> n;
	switch (n)
	{
	case 1:
	{double slength;
	int dw;
	Square zfx;
	cout << "�����������α߳���";
	cin >> slength;
	cout << "��ѡ��λ��" << endl;
	cout << "1 ���ף�2 Ӣ�磻" << endl;
	cin >> dw;
	if (dw == 1) { slength = slength; }
	else { slength = 2.54*slength; }
	zfx.setup(slength);
	showType(zfx);
	showLength(zfx);
	showArea(zfx);
	break;}
	case 2:
	{double l, w;
	Rectangle cfx;
	int dw;
	cout << "�����볤���εĳ��Ϳ�";
	cin >> l >> w;
	cout << "��ѡ��λ:" << endl;
	cout << "1 ���ף�2 Ӣ�磻" << endl;
	cin >> dw;
	if (dw == 1) { l = l;w = w; }
	else { l = 2.54*l;w = 2.54*w; }
	cfx.setup(l, w);
	showType(cfx);
	showLength(cfx);
	showArea(cfx);
	break;}
	case 3:
	{double b;
	double h;
	int dw;
	Triangle sjx;
	cout << "�����������εĵ׺͸ߣ�";
	cin >> b >> h;
	cout << "��ѡ��λ��" << endl;
	cout << "1 ���ף�2 Ӣ�磻" << endl;
	cin >> dw;
	if (dw == 1) { b = b;h = h; }
	else { b = 2.54*b;h = 2.54*h; }
	sjx.setup(b, h);
	showType(sjx);
	showLength(sjx);
	showArea(sjx);
	break;}
	case 4:
	{double r;
	Round yx;
	int dw;
	cout << "������Բ�εİ뾶��";
	cin >> r;
	cout << "��ѡ��λ:" << endl;
	cout << "1 ���ף�2 Ӣ�磻" << endl;
	cin >> dw;
	if (dw == 1) { r = r; }
	else { r = 2.54*r; }
	yx.setup(r);
	showType(yx);
	showLength(yx);
	showArea(yx);
	break;}
	default:
		cout << "Input error!\n";
	}
	return 0;
}