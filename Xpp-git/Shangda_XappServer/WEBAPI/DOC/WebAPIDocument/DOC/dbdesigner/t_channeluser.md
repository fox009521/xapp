# T_ChannelUser频道人员表
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
           <td>CU_Gid</td>
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
           <td>CU_ChannelGid</td>
           <td>nvarchar</td>
           <td>40</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">频道GID</td>
          </tr>
          <tr>
           <td>4</td>
           <td>CU_UserGid</td>
           <td>nvarchar</td>
           <td>64</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>&nbsp;</td>
           <td align="left">人员ID</td>
          </tr>
          <tr>
           <td>5</td>
           <td>CU_IsAdmin</td>
           <td>int</td>
           <td>4</td>
           <td>0</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>0</td>
           <td align="left">是否管理员</td>
          </tr>
          <tr>
           <td>6</td>
           <td>CreateTime</td>
           <td>datetime</td>
           <td>8</td>
           <td>3</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>&nbsp;</td>
           <td>是</td>
           <td>getdate</td>
           <td align="left">加入群日期</td>
          </tr>
          <tr>
           <td>7</td>
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
           <td>8</td>
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
         </tbody>
        </table>

#建表语句
<pre><code>
CREATE TABLE T_ChannelUser
(
	ID INT IDENTITY(1,1),--id
	CU_Gid nvarchar(40) default newid(),--唯一标识
	CU_ChannelGid nvarchar(40),--频道GID
	CU_UserGid nvarchar(64), --人员ID
	CU_IsAdmin int default 0, --是否管理员
	CreateTime datetime default getdate(),--加入群日期
	UpdateTime datetime default getdate(),--更新时间
	status int default 1--状态
)
</code></pre>
