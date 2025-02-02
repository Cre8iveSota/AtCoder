#include <bits/stdc++.h>
using namespace std;
#define rep(i, n) for (int i = 0; i < (int)(n); i++)

int main()
{
    string S;
    cin >> S;

    int ans = 1;
    rep(i, S.size())
    {
        if (S.at(i) == '+')
        {
            ans++;
        }
        else if (S.at(i) == '-')
        {
            ans--;
        }
    }
    cout << ans << endl;
}
