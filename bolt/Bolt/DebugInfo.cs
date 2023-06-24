using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[Documentation(Ignore = true)]
	public class DebugInfo : MonoBehaviour
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00003048 File Offset: 0x00001248
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public static int PollTime
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x8D5450", Offset = "0x8D3A50", VA = "0x1808D5450")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x8D54A0", Offset = "0x8D3AA0", VA = "0x1808D54A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00003060 File Offset: 0x00001260
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A8")]
		public static int SendTime
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x8D5500", Offset = "0x8D3B00", VA = "0x1808D5500")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x8D5550", Offset = "0x8D3B50", VA = "0x1808D5550")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00003078 File Offset: 0x00001278
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A9")]
		public static bool Enabled
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x8D55B0", Offset = "0x8D3BB0", VA = "0x1808D55B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x8D5600", Offset = "0x8D3C00", VA = "0x1808D5600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x8D5660", Offset = "0x8D3C60", VA = "0x1808D5660")]
		public static void Ignore(BoltEntity entity)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x8D5750", Offset = "0x8D3D50", VA = "0x1808D5750")]
		public static void DrawBackground(Rect r)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000AA")]
		public static Texture2D BoltIconTexture
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x8D58E0", Offset = "0x8D3EE0", VA = "0x1808D58E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000AB")]
		public static Texture2D BackgroundTexture
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x8D5B40", Offset = "0x8D4140", VA = "0x1808D5B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000AC")]
		public static GUIStyle LabelStyle
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x8D5D80", Offset = "0x8D4380", VA = "0x1808D5D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000AD")]
		public static GUIStyle LabelStyleBold
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x8D60C0", Offset = "0x8D46C0", VA = "0x1808D60C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x8D6260", Offset = "0x8D4860", VA = "0x1808D6260")]
		public static GUIStyle LabelStyleColor(Color color)
		{
			return null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x8D6360", Offset = "0x8D4960", VA = "0x1808D6360")]
		public static void Label(object value)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x8D6440", Offset = "0x8D4A40", VA = "0x1808D6440")]
		public static void LabelBold(object value)
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x8D6520", Offset = "0x8D4B20", VA = "0x1808D6520")]
		public static void LabelField(object label, object value)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x8D6700", Offset = "0x8D4D00", VA = "0x1808D6700")]
		public static void Show()
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x8D6960", Offset = "0x8D4F60", VA = "0x1808D6960")]
		public static void Hide()
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x8D6BB0", Offset = "0x8D51B0", VA = "0x1808D6BB0")]
		private Color GetColor(int current, int bad)
		{
			return default(Color);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x8D6D00", Offset = "0x8D5300", VA = "0x1808D6D00")]
		private Color GetColor(float t)
		{
			return default(Color);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x8D6E10", Offset = "0x8D5410", VA = "0x1808D6E10")]
		private void DrawEntity(BoltEntity entity)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x8D7290", Offset = "0x8D5890", VA = "0x1808D7290")]
		private void OnGUI()
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x8D9B80", Offset = "0x8D8180", VA = "0x1808D9B80")]
		internal static void SetupAndShow()
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DebugInfo()
		{
		}

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 debugInfoScroll;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x0")]
		private static Entity locked;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x8")]
		private static GUIStyle labelStyle;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x10")]
		private static GUIStyle labelStyleBold;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x18")]
		private static Texture2D boltIconTexture;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x20")]
		private static Texture2D backgroundTexture;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x28")]
		internal static bool showEntityDebugInfo;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x30")]
		internal static HashSet<NetworkId> ignoreList;
	}
}
