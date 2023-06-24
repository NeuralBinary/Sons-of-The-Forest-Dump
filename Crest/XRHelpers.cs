using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace Crest
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public static class XRHelpers
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public static Matrix4x4 LeftEyeProjectionMatrix
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x9D4400", Offset = "0x9D2A00", VA = "0x1809D4400")]
			[CompilerGenerated]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x9D4480", Offset = "0x9D2A80", VA = "0x1809D4480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public static Matrix4x4 RightEyeProjectionMatrix
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x9D44F0", Offset = "0x9D2AF0", VA = "0x1809D44F0")]
			[CompilerGenerated]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x9D4570", Offset = "0x9D2B70", VA = "0x1809D4570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public static Matrix4x4 LeftEyeViewMatrix
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x9D45E0", Offset = "0x9D2BE0", VA = "0x1809D45E0")]
			[CompilerGenerated]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x9D4660", Offset = "0x9D2C60", VA = "0x1809D4660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public static Matrix4x4 RightEyeViewMatrix
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x9D46E0", Offset = "0x9D2CE0", VA = "0x1809D46E0")]
			[CompilerGenerated]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x9D4760", Offset = "0x9D2D60", VA = "0x1809D4760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x17000013")]
		public static bool IsRunning
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x9D47E0", Offset = "0x9D2DE0", VA = "0x1809D47E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x17000014")]
		public static bool IsNewSDKRunning
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x9D4880", Offset = "0x9D2E80", VA = "0x1809D4880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x17000015")]
		public static bool IsOldSDKRunning
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x9D4960", Offset = "0x9D2F60", VA = "0x1809D4960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x17000016")]
		public static bool IsSinglePass
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x9D49B0", Offset = "0x9D2FB0", VA = "0x1809D49B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x17000017")]
		public static int MaximumViews
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x9D4B20", Offset = "0x9D3120", VA = "0x1809D4B20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000018")]
		public static XRDisplaySubsystem Display
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x9D4B70", Offset = "0x9D3170", VA = "0x1809D4B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x9D4C30", Offset = "0x9D3230", VA = "0x1809D4C30")]
		public static void SetViewProjectionMatrices(Camera camera, int viewIndex, int passIndex, CommandBuffer commandBuffer)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x9D5010", Offset = "0x9D3610", VA = "0x1809D5010")]
		public static void SetViewProjectionMatrices(Camera camera)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x9D5400", Offset = "0x9D3A00", VA = "0x1809D5400")]
		public static void UpdatePassIndex(ref int passIndex)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x9D5470", Offset = "0x9D3A70", VA = "0x1809D5470")]
		public static void Update(Camera camera)
		{
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x0")]
		private static List<XRDisplaySubsystem> _displayList;
	}
}
