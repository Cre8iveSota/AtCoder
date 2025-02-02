#include <bits/stdc++.h>
using namespace std;
#define rep(i, n) for (int i = 0; i < (int)(n); i++)

int main()
{
    int A, B, C;
    cin >> A >> B >> C;

    int highest = max(A, max(B, C));
    int lowest = min(A, min(B, C));
    cout << highest - lowest << endl;
}
