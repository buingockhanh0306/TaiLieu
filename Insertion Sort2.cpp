#include <iostream>
using namespace std;
void xuat(int a[], int n)
	{
		int i;
		cout<<"\nDay da duoc sap xep la: ";
		for (i=0; i<=n-1; i++)
		cout<<a[i]<<"  ";
	}
void nhap(int a[], int n)
	{
		int i;
		for (i=0;i<=n-1;i++)
		{
			cout<<"\nNhap phan tu thu "<<i+1<<": ";
			cin>>a[i];
			
		}
	}
int sapxep(int a[], int n)
	{
		int p, x, i;
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
	}
int main()
{
   		int n, i, j, x;
   			cout<<"Day gom bao nhieu so: ";
			cin>>n;
			int a[n];
			nhap(a, n);
			sapxep(a, n);
			xuat(a, n);
			return 0;
	}
		 
