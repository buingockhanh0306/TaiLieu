#include <iostream>
using namespace std;
void merge(int a[], int l, int h, int m)
{
	int i,j,k, x[h - l + 1];
	i = l;
	k = 0;
	j = m +1;
	while(i <= m && j <= h)
	{
		if (a[i] < a[j])
		{
			x[k] = a[i];
			k++;
			i++;
		}
		else
		{
			x[k] = a[j];
			k++;
			j++;
		}
	}
	while (i <= m)
	{
		x[k] = a[i];
		k++;
		i++;
	}
 	while (j <= h)
	{
		x[k] = a[j];
		k++;
		j++;
	}
	for (i = l; i <= h; i++)
	{
		a[i] = x[i-l];
	}
}
void mergesort(int a[], int l, int h)
{
	int m;
	if(l<h)
	{
		m = (l + h)/2;
		mergesort(a,l,m);
		mergesort(a,m+1,h);
		merge(a,l,h,m);
	}
}
int main()
{
	int n,i;
	cout<<"\nNhap so phan tu trong mang: ";cin>>n;
	int a[n];
	for(i = 0; i<n;i++)
	{
		cout<<"\nNhap phan tu thu "<<i+1<<": ";
		cin>>a[i];
	}
	mergesort(a,0,n-1);
	cout<<"\nDay da duoc sap xep: ";
	for(i=0;i<n;i++)
	cout<<"   "<<a[i];
	return 0;
}
