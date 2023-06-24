using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	public enum EInputActionOrigin
	{
		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		k_EInputActionOrigin_None,
		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		k_EInputActionOrigin_SteamController_A,
		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		k_EInputActionOrigin_SteamController_B,
		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		k_EInputActionOrigin_SteamController_X,
		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		k_EInputActionOrigin_SteamController_Y,
		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		k_EInputActionOrigin_SteamController_LeftBumper,
		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		k_EInputActionOrigin_SteamController_RightBumper,
		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		k_EInputActionOrigin_SteamController_LeftGrip,
		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		k_EInputActionOrigin_SteamController_RightGrip,
		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		k_EInputActionOrigin_SteamController_Start,
		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		k_EInputActionOrigin_SteamController_Back,
		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		k_EInputActionOrigin_SteamController_LeftPad_Touch,
		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		k_EInputActionOrigin_SteamController_LeftPad_Swipe,
		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		k_EInputActionOrigin_SteamController_LeftPad_Click,
		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		k_EInputActionOrigin_SteamController_LeftPad_DPadNorth,
		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		k_EInputActionOrigin_SteamController_LeftPad_DPadSouth,
		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		k_EInputActionOrigin_SteamController_LeftPad_DPadWest,
		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		k_EInputActionOrigin_SteamController_LeftPad_DPadEast,
		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		k_EInputActionOrigin_SteamController_RightPad_Touch,
		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		k_EInputActionOrigin_SteamController_RightPad_Swipe,
		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		k_EInputActionOrigin_SteamController_RightPad_Click,
		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		k_EInputActionOrigin_SteamController_RightPad_DPadNorth,
		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		k_EInputActionOrigin_SteamController_RightPad_DPadSouth,
		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		k_EInputActionOrigin_SteamController_RightPad_DPadWest,
		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		k_EInputActionOrigin_SteamController_RightPad_DPadEast,
		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		k_EInputActionOrigin_SteamController_LeftTrigger_Pull,
		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		k_EInputActionOrigin_SteamController_LeftTrigger_Click,
		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		k_EInputActionOrigin_SteamController_RightTrigger_Pull,
		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		k_EInputActionOrigin_SteamController_RightTrigger_Click,
		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		k_EInputActionOrigin_SteamController_LeftStick_Move,
		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		k_EInputActionOrigin_SteamController_LeftStick_Click,
		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		k_EInputActionOrigin_SteamController_LeftStick_DPadNorth,
		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		k_EInputActionOrigin_SteamController_LeftStick_DPadSouth,
		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		k_EInputActionOrigin_SteamController_LeftStick_DPadWest,
		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		k_EInputActionOrigin_SteamController_LeftStick_DPadEast,
		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		k_EInputActionOrigin_SteamController_Gyro_Move,
		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		k_EInputActionOrigin_SteamController_Gyro_Pitch,
		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		k_EInputActionOrigin_SteamController_Gyro_Yaw,
		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		k_EInputActionOrigin_SteamController_Gyro_Roll,
		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		k_EInputActionOrigin_SteamController_Reserved0,
		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		k_EInputActionOrigin_SteamController_Reserved1,
		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		k_EInputActionOrigin_SteamController_Reserved2,
		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		k_EInputActionOrigin_SteamController_Reserved3,
		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		k_EInputActionOrigin_SteamController_Reserved4,
		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		k_EInputActionOrigin_SteamController_Reserved5,
		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		k_EInputActionOrigin_SteamController_Reserved6,
		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		k_EInputActionOrigin_SteamController_Reserved7,
		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		k_EInputActionOrigin_SteamController_Reserved8,
		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		k_EInputActionOrigin_SteamController_Reserved9,
		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		k_EInputActionOrigin_SteamController_Reserved10,
		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		k_EInputActionOrigin_PS4_X,
		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		k_EInputActionOrigin_PS4_Circle,
		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		k_EInputActionOrigin_PS4_Triangle,
		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		k_EInputActionOrigin_PS4_Square,
		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		k_EInputActionOrigin_PS4_LeftBumper,
		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		k_EInputActionOrigin_PS4_RightBumper,
		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		k_EInputActionOrigin_PS4_Options,
		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		k_EInputActionOrigin_PS4_Share,
		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		k_EInputActionOrigin_PS4_LeftPad_Touch,
		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		k_EInputActionOrigin_PS4_LeftPad_Swipe,
		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		k_EInputActionOrigin_PS4_LeftPad_Click,
		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		k_EInputActionOrigin_PS4_LeftPad_DPadNorth,
		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		k_EInputActionOrigin_PS4_LeftPad_DPadSouth,
		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		k_EInputActionOrigin_PS4_LeftPad_DPadWest,
		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		k_EInputActionOrigin_PS4_LeftPad_DPadEast,
		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		k_EInputActionOrigin_PS4_RightPad_Touch,
		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		k_EInputActionOrigin_PS4_RightPad_Swipe,
		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		k_EInputActionOrigin_PS4_RightPad_Click,
		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		k_EInputActionOrigin_PS4_RightPad_DPadNorth,
		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		k_EInputActionOrigin_PS4_RightPad_DPadSouth,
		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		k_EInputActionOrigin_PS4_RightPad_DPadWest,
		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		k_EInputActionOrigin_PS4_RightPad_DPadEast,
		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		k_EInputActionOrigin_PS4_CenterPad_Touch,
		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		k_EInputActionOrigin_PS4_CenterPad_Swipe,
		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		k_EInputActionOrigin_PS4_CenterPad_Click,
		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		k_EInputActionOrigin_PS4_CenterPad_DPadNorth,
		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		k_EInputActionOrigin_PS4_CenterPad_DPadSouth,
		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		k_EInputActionOrigin_PS4_CenterPad_DPadWest,
		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		k_EInputActionOrigin_PS4_CenterPad_DPadEast,
		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		k_EInputActionOrigin_PS4_LeftTrigger_Pull,
		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		k_EInputActionOrigin_PS4_LeftTrigger_Click,
		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		k_EInputActionOrigin_PS4_RightTrigger_Pull,
		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		k_EInputActionOrigin_PS4_RightTrigger_Click,
		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		k_EInputActionOrigin_PS4_LeftStick_Move,
		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		k_EInputActionOrigin_PS4_LeftStick_Click,
		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		k_EInputActionOrigin_PS4_LeftStick_DPadNorth,
		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		k_EInputActionOrigin_PS4_LeftStick_DPadSouth,
		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		k_EInputActionOrigin_PS4_LeftStick_DPadWest,
		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		k_EInputActionOrigin_PS4_LeftStick_DPadEast,
		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		k_EInputActionOrigin_PS4_RightStick_Move,
		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		k_EInputActionOrigin_PS4_RightStick_Click,
		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		k_EInputActionOrigin_PS4_RightStick_DPadNorth,
		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		k_EInputActionOrigin_PS4_RightStick_DPadSouth,
		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		k_EInputActionOrigin_PS4_RightStick_DPadWest,
		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		k_EInputActionOrigin_PS4_RightStick_DPadEast,
		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		k_EInputActionOrigin_PS4_DPad_North,
		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		k_EInputActionOrigin_PS4_DPad_South,
		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		k_EInputActionOrigin_PS4_DPad_West,
		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		k_EInputActionOrigin_PS4_DPad_East,
		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		k_EInputActionOrigin_PS4_Gyro_Move,
		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		k_EInputActionOrigin_PS4_Gyro_Pitch,
		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		k_EInputActionOrigin_PS4_Gyro_Yaw,
		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		k_EInputActionOrigin_PS4_Gyro_Roll,
		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		k_EInputActionOrigin_PS4_DPad_Move,
		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		k_EInputActionOrigin_PS4_Reserved1,
		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		k_EInputActionOrigin_PS4_Reserved2,
		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		k_EInputActionOrigin_PS4_Reserved3,
		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		k_EInputActionOrigin_PS4_Reserved4,
		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		k_EInputActionOrigin_PS4_Reserved5,
		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		k_EInputActionOrigin_PS4_Reserved6,
		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		k_EInputActionOrigin_PS4_Reserved7,
		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		k_EInputActionOrigin_PS4_Reserved8,
		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		k_EInputActionOrigin_PS4_Reserved9,
		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		k_EInputActionOrigin_PS4_Reserved10,
		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		k_EInputActionOrigin_XBoxOne_A,
		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		k_EInputActionOrigin_XBoxOne_B,
		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		k_EInputActionOrigin_XBoxOne_X,
		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		k_EInputActionOrigin_XBoxOne_Y,
		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		k_EInputActionOrigin_XBoxOne_LeftBumper,
		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		k_EInputActionOrigin_XBoxOne_RightBumper,
		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		k_EInputActionOrigin_XBoxOne_Menu,
		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		k_EInputActionOrigin_XBoxOne_View,
		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		k_EInputActionOrigin_XBoxOne_LeftTrigger_Pull,
		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		k_EInputActionOrigin_XBoxOne_LeftTrigger_Click,
		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		k_EInputActionOrigin_XBoxOne_RightTrigger_Pull,
		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		k_EInputActionOrigin_XBoxOne_RightTrigger_Click,
		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		k_EInputActionOrigin_XBoxOne_LeftStick_Move,
		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		k_EInputActionOrigin_XBoxOne_LeftStick_Click,
		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadNorth,
		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadSouth,
		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadWest,
		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadEast,
		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		k_EInputActionOrigin_XBoxOne_RightStick_Move,
		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		k_EInputActionOrigin_XBoxOne_RightStick_Click,
		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		k_EInputActionOrigin_XBoxOne_RightStick_DPadNorth,
		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		k_EInputActionOrigin_XBoxOne_RightStick_DPadSouth,
		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		k_EInputActionOrigin_XBoxOne_RightStick_DPadWest,
		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		k_EInputActionOrigin_XBoxOne_RightStick_DPadEast,
		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		k_EInputActionOrigin_XBoxOne_DPad_North,
		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		k_EInputActionOrigin_XBoxOne_DPad_South,
		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		k_EInputActionOrigin_XBoxOne_DPad_West,
		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		k_EInputActionOrigin_XBoxOne_DPad_East,
		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		k_EInputActionOrigin_XBoxOne_DPad_Move,
		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		k_EInputActionOrigin_XBoxOne_LeftGrip_Lower,
		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		k_EInputActionOrigin_XBoxOne_LeftGrip_Upper,
		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		k_EInputActionOrigin_XBoxOne_RightGrip_Lower,
		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		k_EInputActionOrigin_XBoxOne_RightGrip_Upper,
		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		k_EInputActionOrigin_XBoxOne_Share,
		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		k_EInputActionOrigin_XBoxOne_Reserved6,
		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		k_EInputActionOrigin_XBoxOne_Reserved7,
		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		k_EInputActionOrigin_XBoxOne_Reserved8,
		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		k_EInputActionOrigin_XBoxOne_Reserved9,
		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		k_EInputActionOrigin_XBoxOne_Reserved10,
		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		k_EInputActionOrigin_XBox360_A,
		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		k_EInputActionOrigin_XBox360_B,
		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		k_EInputActionOrigin_XBox360_X,
		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		k_EInputActionOrigin_XBox360_Y,
		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		k_EInputActionOrigin_XBox360_LeftBumper,
		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		k_EInputActionOrigin_XBox360_RightBumper,
		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		k_EInputActionOrigin_XBox360_Start,
		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		k_EInputActionOrigin_XBox360_Back,
		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		k_EInputActionOrigin_XBox360_LeftTrigger_Pull,
		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		k_EInputActionOrigin_XBox360_LeftTrigger_Click,
		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		k_EInputActionOrigin_XBox360_RightTrigger_Pull,
		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		k_EInputActionOrigin_XBox360_RightTrigger_Click,
		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		k_EInputActionOrigin_XBox360_LeftStick_Move,
		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		k_EInputActionOrigin_XBox360_LeftStick_Click,
		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		k_EInputActionOrigin_XBox360_LeftStick_DPadNorth,
		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		k_EInputActionOrigin_XBox360_LeftStick_DPadSouth,
		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		k_EInputActionOrigin_XBox360_LeftStick_DPadWest,
		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		k_EInputActionOrigin_XBox360_LeftStick_DPadEast,
		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		k_EInputActionOrigin_XBox360_RightStick_Move,
		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		k_EInputActionOrigin_XBox360_RightStick_Click,
		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		k_EInputActionOrigin_XBox360_RightStick_DPadNorth,
		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		k_EInputActionOrigin_XBox360_RightStick_DPadSouth,
		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		k_EInputActionOrigin_XBox360_RightStick_DPadWest,
		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		k_EInputActionOrigin_XBox360_RightStick_DPadEast,
		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		k_EInputActionOrigin_XBox360_DPad_North,
		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		k_EInputActionOrigin_XBox360_DPad_South,
		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		k_EInputActionOrigin_XBox360_DPad_West,
		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		k_EInputActionOrigin_XBox360_DPad_East,
		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		k_EInputActionOrigin_XBox360_DPad_Move,
		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		k_EInputActionOrigin_XBox360_Reserved1,
		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		k_EInputActionOrigin_XBox360_Reserved2,
		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		k_EInputActionOrigin_XBox360_Reserved3,
		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		k_EInputActionOrigin_XBox360_Reserved4,
		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		k_EInputActionOrigin_XBox360_Reserved5,
		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		k_EInputActionOrigin_XBox360_Reserved6,
		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		k_EInputActionOrigin_XBox360_Reserved7,
		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		k_EInputActionOrigin_XBox360_Reserved8,
		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		k_EInputActionOrigin_XBox360_Reserved9,
		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		k_EInputActionOrigin_XBox360_Reserved10,
		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		k_EInputActionOrigin_Switch_A,
		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		k_EInputActionOrigin_Switch_B,
		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		k_EInputActionOrigin_Switch_X,
		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		k_EInputActionOrigin_Switch_Y,
		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		k_EInputActionOrigin_Switch_LeftBumper,
		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		k_EInputActionOrigin_Switch_RightBumper,
		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		k_EInputActionOrigin_Switch_Plus,
		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		k_EInputActionOrigin_Switch_Minus,
		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		k_EInputActionOrigin_Switch_Capture,
		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		k_EInputActionOrigin_Switch_LeftTrigger_Pull,
		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		k_EInputActionOrigin_Switch_LeftTrigger_Click,
		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		k_EInputActionOrigin_Switch_RightTrigger_Pull,
		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		k_EInputActionOrigin_Switch_RightTrigger_Click,
		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		k_EInputActionOrigin_Switch_LeftStick_Move,
		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		k_EInputActionOrigin_Switch_LeftStick_Click,
		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		k_EInputActionOrigin_Switch_LeftStick_DPadNorth,
		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		k_EInputActionOrigin_Switch_LeftStick_DPadSouth,
		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		k_EInputActionOrigin_Switch_LeftStick_DPadWest,
		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		k_EInputActionOrigin_Switch_LeftStick_DPadEast,
		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		k_EInputActionOrigin_Switch_RightStick_Move,
		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		k_EInputActionOrigin_Switch_RightStick_Click,
		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		k_EInputActionOrigin_Switch_RightStick_DPadNorth,
		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		k_EInputActionOrigin_Switch_RightStick_DPadSouth,
		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		k_EInputActionOrigin_Switch_RightStick_DPadWest,
		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		k_EInputActionOrigin_Switch_RightStick_DPadEast,
		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		k_EInputActionOrigin_Switch_DPad_North,
		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		k_EInputActionOrigin_Switch_DPad_South,
		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		k_EInputActionOrigin_Switch_DPad_West,
		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		k_EInputActionOrigin_Switch_DPad_East,
		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		k_EInputActionOrigin_Switch_ProGyro_Move,
		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		k_EInputActionOrigin_Switch_ProGyro_Pitch,
		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		k_EInputActionOrigin_Switch_ProGyro_Yaw,
		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		k_EInputActionOrigin_Switch_ProGyro_Roll,
		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		k_EInputActionOrigin_Switch_DPad_Move,
		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		k_EInputActionOrigin_Switch_Reserved1,
		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		k_EInputActionOrigin_Switch_Reserved2,
		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		k_EInputActionOrigin_Switch_Reserved3,
		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		k_EInputActionOrigin_Switch_Reserved4,
		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		k_EInputActionOrigin_Switch_Reserved5,
		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		k_EInputActionOrigin_Switch_Reserved6,
		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		k_EInputActionOrigin_Switch_Reserved7,
		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		k_EInputActionOrigin_Switch_Reserved8,
		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		k_EInputActionOrigin_Switch_Reserved9,
		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		k_EInputActionOrigin_Switch_Reserved10,
		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		k_EInputActionOrigin_Switch_RightGyro_Move,
		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		k_EInputActionOrigin_Switch_RightGyro_Pitch,
		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		k_EInputActionOrigin_Switch_RightGyro_Yaw,
		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		k_EInputActionOrigin_Switch_RightGyro_Roll,
		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		k_EInputActionOrigin_Switch_LeftGyro_Move,
		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		k_EInputActionOrigin_Switch_LeftGyro_Pitch,
		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		k_EInputActionOrigin_Switch_LeftGyro_Yaw,
		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		k_EInputActionOrigin_Switch_LeftGyro_Roll,
		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		k_EInputActionOrigin_Switch_LeftGrip_Lower,
		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		k_EInputActionOrigin_Switch_LeftGrip_Upper,
		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		k_EInputActionOrigin_Switch_RightGrip_Lower,
		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		k_EInputActionOrigin_Switch_RightGrip_Upper,
		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		k_EInputActionOrigin_Switch_Reserved11,
		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		k_EInputActionOrigin_Switch_Reserved12,
		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		k_EInputActionOrigin_Switch_Reserved13,
		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		k_EInputActionOrigin_Switch_Reserved14,
		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		k_EInputActionOrigin_Switch_Reserved15,
		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		k_EInputActionOrigin_Switch_Reserved16,
		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		k_EInputActionOrigin_Switch_Reserved17,
		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		k_EInputActionOrigin_Switch_Reserved18,
		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		k_EInputActionOrigin_Switch_Reserved19,
		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		k_EInputActionOrigin_Switch_Reserved20,
		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		k_EInputActionOrigin_PS5_X,
		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		k_EInputActionOrigin_PS5_Circle,
		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		k_EInputActionOrigin_PS5_Triangle,
		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		k_EInputActionOrigin_PS5_Square,
		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		k_EInputActionOrigin_PS5_LeftBumper,
		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		k_EInputActionOrigin_PS5_RightBumper,
		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		k_EInputActionOrigin_PS5_Option,
		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		k_EInputActionOrigin_PS5_Create,
		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		k_EInputActionOrigin_PS5_Mute,
		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		k_EInputActionOrigin_PS5_LeftPad_Touch,
		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		k_EInputActionOrigin_PS5_LeftPad_Swipe,
		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		k_EInputActionOrigin_PS5_LeftPad_Click,
		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		k_EInputActionOrigin_PS5_LeftPad_DPadNorth,
		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		k_EInputActionOrigin_PS5_LeftPad_DPadSouth,
		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		k_EInputActionOrigin_PS5_LeftPad_DPadWest,
		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		k_EInputActionOrigin_PS5_LeftPad_DPadEast,
		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		k_EInputActionOrigin_PS5_RightPad_Touch,
		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		k_EInputActionOrigin_PS5_RightPad_Swipe,
		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		k_EInputActionOrigin_PS5_RightPad_Click,
		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		k_EInputActionOrigin_PS5_RightPad_DPadNorth,
		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		k_EInputActionOrigin_PS5_RightPad_DPadSouth,
		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		k_EInputActionOrigin_PS5_RightPad_DPadWest,
		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		k_EInputActionOrigin_PS5_RightPad_DPadEast,
		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		k_EInputActionOrigin_PS5_CenterPad_Touch,
		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		k_EInputActionOrigin_PS5_CenterPad_Swipe,
		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		k_EInputActionOrigin_PS5_CenterPad_Click,
		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		k_EInputActionOrigin_PS5_CenterPad_DPadNorth,
		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		k_EInputActionOrigin_PS5_CenterPad_DPadSouth,
		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		k_EInputActionOrigin_PS5_CenterPad_DPadWest,
		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		k_EInputActionOrigin_PS5_CenterPad_DPadEast,
		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		k_EInputActionOrigin_PS5_LeftTrigger_Pull,
		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		k_EInputActionOrigin_PS5_LeftTrigger_Click,
		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		k_EInputActionOrigin_PS5_RightTrigger_Pull,
		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		k_EInputActionOrigin_PS5_RightTrigger_Click,
		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		k_EInputActionOrigin_PS5_LeftStick_Move,
		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		k_EInputActionOrigin_PS5_LeftStick_Click,
		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		k_EInputActionOrigin_PS5_LeftStick_DPadNorth,
		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		k_EInputActionOrigin_PS5_LeftStick_DPadSouth,
		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		k_EInputActionOrigin_PS5_LeftStick_DPadWest,
		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		k_EInputActionOrigin_PS5_LeftStick_DPadEast,
		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		k_EInputActionOrigin_PS5_RightStick_Move,
		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		k_EInputActionOrigin_PS5_RightStick_Click,
		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		k_EInputActionOrigin_PS5_RightStick_DPadNorth,
		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		k_EInputActionOrigin_PS5_RightStick_DPadSouth,
		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		k_EInputActionOrigin_PS5_RightStick_DPadWest,
		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		k_EInputActionOrigin_PS5_RightStick_DPadEast,
		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		k_EInputActionOrigin_PS5_DPad_North,
		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		k_EInputActionOrigin_PS5_DPad_South,
		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		k_EInputActionOrigin_PS5_DPad_West,
		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		k_EInputActionOrigin_PS5_DPad_East,
		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		k_EInputActionOrigin_PS5_Gyro_Move,
		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		k_EInputActionOrigin_PS5_Gyro_Pitch,
		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		k_EInputActionOrigin_PS5_Gyro_Yaw,
		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		k_EInputActionOrigin_PS5_Gyro_Roll,
		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		k_EInputActionOrigin_PS5_DPad_Move,
		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		k_EInputActionOrigin_PS5_Reserved1,
		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		k_EInputActionOrigin_PS5_Reserved2,
		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		k_EInputActionOrigin_PS5_Reserved3,
		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		k_EInputActionOrigin_PS5_Reserved4,
		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		k_EInputActionOrigin_PS5_Reserved5,
		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		k_EInputActionOrigin_PS5_Reserved6,
		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		k_EInputActionOrigin_PS5_Reserved7,
		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		k_EInputActionOrigin_PS5_Reserved8,
		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		k_EInputActionOrigin_PS5_Reserved9,
		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		k_EInputActionOrigin_PS5_Reserved10,
		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		k_EInputActionOrigin_PS5_Reserved11,
		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		k_EInputActionOrigin_PS5_Reserved12,
		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		k_EInputActionOrigin_PS5_Reserved13,
		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		k_EInputActionOrigin_PS5_Reserved14,
		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		k_EInputActionOrigin_PS5_Reserved15,
		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		k_EInputActionOrigin_PS5_Reserved16,
		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		k_EInputActionOrigin_PS5_Reserved17,
		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		k_EInputActionOrigin_PS5_Reserved18,
		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		k_EInputActionOrigin_PS5_Reserved19,
		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		k_EInputActionOrigin_PS5_Reserved20,
		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		k_EInputActionOrigin_SteamDeck_A,
		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		k_EInputActionOrigin_SteamDeck_B,
		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		k_EInputActionOrigin_SteamDeck_X,
		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		k_EInputActionOrigin_SteamDeck_Y,
		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		k_EInputActionOrigin_SteamDeck_L1,
		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		k_EInputActionOrigin_SteamDeck_R1,
		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		k_EInputActionOrigin_SteamDeck_Menu,
		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		k_EInputActionOrigin_SteamDeck_View,
		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		k_EInputActionOrigin_SteamDeck_LeftPad_Touch,
		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		k_EInputActionOrigin_SteamDeck_LeftPad_Swipe,
		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		k_EInputActionOrigin_SteamDeck_LeftPad_Click,
		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		k_EInputActionOrigin_SteamDeck_LeftPad_DPadNorth,
		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		k_EInputActionOrigin_SteamDeck_LeftPad_DPadSouth,
		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		k_EInputActionOrigin_SteamDeck_LeftPad_DPadWest,
		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		k_EInputActionOrigin_SteamDeck_LeftPad_DPadEast,
		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		k_EInputActionOrigin_SteamDeck_RightPad_Touch,
		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		k_EInputActionOrigin_SteamDeck_RightPad_Swipe,
		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		k_EInputActionOrigin_SteamDeck_RightPad_Click,
		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		k_EInputActionOrigin_SteamDeck_RightPad_DPadNorth,
		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		k_EInputActionOrigin_SteamDeck_RightPad_DPadSouth,
		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		k_EInputActionOrigin_SteamDeck_RightPad_DPadWest,
		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		k_EInputActionOrigin_SteamDeck_RightPad_DPadEast,
		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		k_EInputActionOrigin_SteamDeck_L2_SoftPull,
		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		k_EInputActionOrigin_SteamDeck_L2,
		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		k_EInputActionOrigin_SteamDeck_R2_SoftPull,
		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		k_EInputActionOrigin_SteamDeck_R2,
		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		k_EInputActionOrigin_SteamDeck_LeftStick_Move,
		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		k_EInputActionOrigin_SteamDeck_L3,
		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		k_EInputActionOrigin_SteamDeck_LeftStick_DPadNorth,
		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		k_EInputActionOrigin_SteamDeck_LeftStick_DPadSouth,
		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		k_EInputActionOrigin_SteamDeck_LeftStick_DPadWest,
		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		k_EInputActionOrigin_SteamDeck_LeftStick_DPadEast,
		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		k_EInputActionOrigin_SteamDeck_LeftStick_Touch,
		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		k_EInputActionOrigin_SteamDeck_RightStick_Move,
		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		k_EInputActionOrigin_SteamDeck_R3,
		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		k_EInputActionOrigin_SteamDeck_RightStick_DPadNorth,
		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		k_EInputActionOrigin_SteamDeck_RightStick_DPadSouth,
		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		k_EInputActionOrigin_SteamDeck_RightStick_DPadWest,
		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		k_EInputActionOrigin_SteamDeck_RightStick_DPadEast,
		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		k_EInputActionOrigin_SteamDeck_RightStick_Touch,
		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		k_EInputActionOrigin_SteamDeck_L4,
		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		k_EInputActionOrigin_SteamDeck_R4,
		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		k_EInputActionOrigin_SteamDeck_L5,
		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		k_EInputActionOrigin_SteamDeck_R5,
		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		k_EInputActionOrigin_SteamDeck_DPad_Move,
		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		k_EInputActionOrigin_SteamDeck_DPad_North,
		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		k_EInputActionOrigin_SteamDeck_DPad_South,
		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		k_EInputActionOrigin_SteamDeck_DPad_West,
		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		k_EInputActionOrigin_SteamDeck_DPad_East,
		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		k_EInputActionOrigin_SteamDeck_Gyro_Move,
		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		k_EInputActionOrigin_SteamDeck_Gyro_Pitch,
		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		k_EInputActionOrigin_SteamDeck_Gyro_Yaw,
		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		k_EInputActionOrigin_SteamDeck_Gyro_Roll,
		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		k_EInputActionOrigin_SteamDeck_Reserved1,
		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		k_EInputActionOrigin_SteamDeck_Reserved2,
		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		k_EInputActionOrigin_SteamDeck_Reserved3,
		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		k_EInputActionOrigin_SteamDeck_Reserved4,
		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		k_EInputActionOrigin_SteamDeck_Reserved5,
		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		k_EInputActionOrigin_SteamDeck_Reserved6,
		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		k_EInputActionOrigin_SteamDeck_Reserved7,
		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		k_EInputActionOrigin_SteamDeck_Reserved8,
		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		k_EInputActionOrigin_SteamDeck_Reserved9,
		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		k_EInputActionOrigin_SteamDeck_Reserved10,
		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		k_EInputActionOrigin_SteamDeck_Reserved11,
		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		k_EInputActionOrigin_SteamDeck_Reserved12,
		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		k_EInputActionOrigin_SteamDeck_Reserved13,
		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		k_EInputActionOrigin_SteamDeck_Reserved14,
		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		k_EInputActionOrigin_SteamDeck_Reserved15,
		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		k_EInputActionOrigin_SteamDeck_Reserved16,
		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		k_EInputActionOrigin_SteamDeck_Reserved17,
		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		k_EInputActionOrigin_SteamDeck_Reserved18,
		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		k_EInputActionOrigin_SteamDeck_Reserved19,
		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		k_EInputActionOrigin_SteamDeck_Reserved20,
		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		k_EInputActionOrigin_Count,
		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		k_EInputActionOrigin_MaximumPossibleValue = 32767
	}
}
