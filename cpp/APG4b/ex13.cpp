#include <bits/stdc++.h>
using namespace std;
#define rep(i, n) for (int i = 0; i < (int)(n); i++)

int main()
{
    int N;
    cin >> N;
    vector<int> A(N);

    rep(i, N)
    {
        cin >> A.at(i);
    }
    int sum;
    rep(i, N)
    {
        sum += A.at(i);
    }
    rep(i, N)
    {
        cout << abs(A.at(i) - sum / N) << endl;
    }
}
