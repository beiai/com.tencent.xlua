本想把 xlua 改造成 package 模式的，试了下有点麻烦，后来改成适配 HybridCLR 模式了

Api 是非热更的 AOT 接口

Editor 是 XLua 编辑器相关代码

Runtime 是 XLua 运行时相关代码，可以放 AOT，也可以放在热更新里

生成的代码放到 Runtime/Gen/ 目录下了

并不是开箱即用的状态，用到自己项目里还是需要做一定的调整的

