/*Giai bai toan sap xep bang phuong phap Insertion Sort*/
#include<iostream>
using namespace std;
void xuat(int a[], int n)
	{
		int i;
		cout<<"\nDay da sap xep la: ";
		for (i=0; i<=n-1; i++) cout<<a[i]<<"  ";
	}
int main()
{
	int n, i, x, p;
	cout<<"\nDay do gom bao nieu phan tu: ";
	cin>>n;
	int a[n];
	for (i=0; i<=n-1; i++)
		{
			cout<<"\nNhap phan tu thu "<<i+1<<": ";
			cin>>a[i];
		};
	for (i=0; i<=n-1; i++)
		{
			x=a[i];
			p=i;
			while ((p>0)&&(a[p-1]>x))
				{
					a[p]=a[p-1];
					p--;
				};
	a[p]=x;
		};
	xuat(a, n);
	return 0;
}
/*Bui Ngoc Khanh-1800587-K42L_CNTT*/
