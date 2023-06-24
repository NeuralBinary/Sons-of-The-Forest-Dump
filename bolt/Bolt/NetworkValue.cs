using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[StructLayout(2)]
	internal struct NetworkValue
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x170000B6")]
		public bool HasNonDefaultValue
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x8DAE10", Offset = "0x8D9410", VA = "0x1808DAE10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B7")]
		public Matrix4x4 Matrix4x4
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x8DAE30", Offset = "0x8D9430", VA = "0x1808DAE30")]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x8DAEC0", Offset = "0x8D94C0", VA = "0x1808DAEC0")]
			set
			{
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B8")]
		public string String
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x8DAF70", Offset = "0x8D9570", VA = "0x1808DAF70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B9")]
		public IProtocolToken ProtocolToken
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x8DAFC0", Offset = "0x8D95C0", VA = "0x1808DAFC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BA")]
		public NetworkTransform Transform
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x8DB030", Offset = "0x8D9630", VA = "0x1808DB030")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BB")]
		public Action Action
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x8DB0A0", Offset = "0x8D96A0", VA = "0x1808DB0A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BC")]
		public BoltEntity Entity
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x8DB0F0", Offset = "0x8D96F0", VA = "0x1808DB0F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x8DB140", Offset = "0x8D9740", VA = "0x1808DB140")]
			set
			{
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x6F0B10", Offset = "0x6EF110", VA = "0x1806F0B10")]
		public static bool Diff(bool a, bool b)
		{
			return default(bool);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool Diff(int a, int b)
		{
			return default(bool);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x8DB240", Offset = "0x8D9840", VA = "0x1808DB240")]
		public static bool Diff(Guid a, Guid b)
		{
			return default(bool);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x8DB2A0", Offset = "0x8D98A0", VA = "0x1808DB2A0")]
		public static bool Diff(float a, float b)
		{
			return default(bool);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool Diff(NetworkId a, NetworkId b)
		{
			return default(bool);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool Diff(PrefabId a, PrefabId b)
		{
			return default(bool);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x65FF90", Offset = "0x65E590", VA = "0x18065FF90")]
		public static bool Diff(NetworkTrigger a, NetworkTrigger b)
		{
			return default(bool);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool Diff(object a, object b)
		{
			return default(bool);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x8DB2C0", Offset = "0x8D98C0", VA = "0x1808DB2C0")]
		public static bool Diff(Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x8DB310", Offset = "0x8D9910", VA = "0x1808DB310")]
		public static bool Diff(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x8DB380", Offset = "0x8D9980", VA = "0x1808DB380")]
		public static bool Diff(Quaternion a, Quaternion b)
		{
			return default(bool);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x8DB3E0", Offset = "0x8D99E0", VA = "0x1808DB3E0")]
		public static bool Diff(Color a, Color b)
		{
			return default(bool);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x8DB450", Offset = "0x8D9A50", VA = "0x1808DB450")]
		public static bool Diff(Color32 a, Color32 b)
		{
			return default(bool);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x8DB490", Offset = "0x8D9A90", VA = "0x1808DB490")]
		public static bool Diff(Matrix4x4 a, Matrix4x4 b)
		{
			return default(bool);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x8DB500", Offset = "0x8D9B00", VA = "0x1808DB500")]
		public static bool Diff_Strict(Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x8DB540", Offset = "0x8D9B40", VA = "0x1808DB540")]
		public static bool Diff_Strict(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x8DB570", Offset = "0x8D9B70", VA = "0x1808DB570")]
		public static bool Diff_Strict(Quaternion a, Quaternion b)
		{
			return default(bool);
		}

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong Packed0;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong Packed1;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Bool;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Int0;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Float0;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Float1;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Float2;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float Float3;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Guid Guid;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NetworkId NetworkId;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PrefabId PrefabId;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NetworkTrigger TriggerLocal;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public NetworkTrigger TriggerSend;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector2 Vector2;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Vector3;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion Quaternion;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Color Color;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Color32 Color32;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object Object;
	}
}
