# 说明

打游戏时有时会录下一些风骚操作，想剪辑一下视频。网上的相关工具，有收费、速度慢、有水印、降低画质等缺点，所以在网上随意查些资料后，就做了这个简陋且一堆BUG的软件，毕竟自己用~

![MainForm.png](https://github.com/zhengDaFeng/VideoCutter/blob/master/Image/MainForm.PNG?raw=true)

合并视频、音频文件：

./ffmpeg -ss 00:00:00 -t 00:00:22 -i 1.mp4 -ss 00:00:00 -t 00:00:22 -i 2.mp3 -c:v copy -c:a aac -strict experimental -map 0:v:0 -map 1:a:0 -y output.mp4