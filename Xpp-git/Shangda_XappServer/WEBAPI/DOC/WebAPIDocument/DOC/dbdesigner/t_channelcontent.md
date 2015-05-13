# T_ChannelContent频道内容表

<table cellspacing="0" cellpadding="5" border="1" width="100%" bordercolorlight="#D7D7E5" bordercolordark="#D3D8E0">
         <tbody>
          <tr bgcolor="#F0F0F0">
           <td>序号</td>
           <td>列名</td>
           <td>数据类型</td>
           <td>长度</td>
           <td>小数位</td>
           <td>标识</td>
           <td>主键</td>
           <td>外键</td>
           <td>允许空</td>
           <td>默认值</td>
           <td>说明</td>
          </tr>
          <tr>
           <td>1</td>
           <td>ID</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>否</td>
           <td>&nbsp;</td>
           <td align="left">id</td>
          </tr>
          <tr>
           <td>2</td>
           <td>CC_Gid</td>
           <td>nvarchar</td>
           <td>40</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>newid</td>
           <td align="left">唯一标识</td>
          </tr>
          <tr>
           <td>3</td>
           <td>CC_Content</td>
           <td>nvarchar</td>
           <td>2000</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">内容描述</td>
          </tr>
          <tr>
           <td>4</td>
           <td>CC_PicUrl</td>
           <td>nvarchar</td>
           <td>3000</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">图片URL</td>
          </tr>
          <tr>
           <td>5</td>
           <td>CC_ReplyCount</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>0</td>
           <td align="left">回复个数</td>
          </tr>
          <tr>
           <td>6</td>
           <td>CC_AgreeCount</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>0</td>
           <td align="left">点赞个数</td>
          </tr>
          <tr>
           <td>7</td>
           <td>CC_Creater</td>
           <td>nvarchar</td>
           <td>64</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">发布人员</td>
          </tr>
          <tr>
           <td>8</td>
           <td>CreateTime</td>
           <td>datetime</td>
           <td>8</td>
           <td>3</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>getdate</td>
           <td align="left">新增时间</td>
          </tr>
          <tr>
           <td>9</td>
           <td>UpdateTime</td>
           <td>datetime</td>
           <td>8</td>
           <td>3</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>getdate</td>
           <td align="left">更新时间</td>
          </tr>
          <tr>
           <td>10</td>
           <td>status</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>1</td>
           <td align="left">状态</td>
          </tr>
          <tr>
           <td>10</td>
           <td>CC_ChannelGid</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>1</td>
           <td align="left">所属频道</td>
          </tr>
         </tbody>
        </table>
#建表语句
<pre><code>
Create Table T_ChannelContent
(
	ID INT IDENTITY(1,1),--id
	CC_Gid nvarchar(40) default newid(),--唯一标识
	CC_Content nvarchar(2000),--内容描述
	CC_PicUrl nvarchar(3000), --图片URL
	CC_ReplyCount int default 0,--回复个数
	CC_AgreeCount int default 0,--点赞个数
	CC_Creater nvarchar(64), --发布人员
	CreateTime datetime default getdate(),
	UpdateTime datetime default getdate(),
	status int default 1, --状态
	CC_ChannelGid nvarchar(40)
)
</code></pre>
