# AtCoder

AtCoder の実装・テストプロジェクトのテンプレート

## 準備

### 使用ツールインストール

- atcoder-cli
  - npm で入れます npm install -g atcoder-cli
  - コマンドは acc xxx
- online-judge-tools
  - pip3 install online-judge-tools

### ログイン

- npm run accin
  - acc login が実行される
- npm run ojin
  - oj login https://atcoder.jp/ が実行される

## 使い方

- AtCoder Beginner Contest 166 を解く場合

  - acc new abc166 を実行
    - コンソールで解きたい問題を選択しエンター
    - 問題内容は contest.acc.json を確認し url をクリックしてブラウザで表示する
  - 対象の dir が先のコマンドでできるために移動
    - (例)a 問題を解く場合は cd abc166/a/
  - npm run test でテスト
  - npm run submit で提出

## 参考

- 本実行環境準備方法
  - https://oita.oika.me/2020/05/10/at-coder-csharp/
    - 注意点 上記 リンク 誤植あり
      - x.config→x.csproj
    - For HiguchiSodapop edit 使用汎用テンプレートを追加
      - https://qiita.com/sekikatsu/items/93c41c6c937ed1dfcf23 参考
