# T_ChannelReply频道回复表
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
           <td>CR_Gid</td>
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
           <td>CR_ContentGid</td>
           <td>nvarchar</td>
           <td>40</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">内容GID</td>
          </tr>
          <tr>
           <td>4</td>
           <td>CR_ReplyContent</td>
           <td>nvarchar</td>
           <td>4000</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">回复内容</td>
          </tr>
          <tr>
           <td>5</td>
           <td>CR_Creater</td>
           <td>nvarchar</td>
           <td>64</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">回复人/td>
          </tr>
          <tr>
           <td>6</td>
           <td>CR_ReplyUser</td>
           <td>nvarchar</td>
           <td>64</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">被回复人GID</td>
          </tr>
          <tr>
           <td>7</td>
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
           <td>8</td>
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
           <td>9</td>
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
           <td>CR_ReplyGid</td>
           <td>nvarchar</td>
           <td>40</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>1</td>
           <td align="left">被回复GID</td>
          </tr>
         </tbody>
        </table>
#建表语句
<pre><code>
Create Table T_ChannelReply
(
	ID INT IDENTITY(1,1),--id
	CR_Gid nvarchar(40) default newid(),--唯一标识
	CR_ContentGid nvarchar(40), --内容GID
	CR_ReplyContent nvarchar(4000), --回复内容
	CR_Creater nvarchar(64), --回复人
	CR_ReplyUser nvarchar(64), --被回复人GID
	CreateTime datetime default getdate(),
	UpdateTime datetime default getdate(),
	status int default 1,--状态
	CR_ReplyGid NVARCHAR(40)
)
</code></pre>
