using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000214 RID: 532
	[Token(Token = "0x2000214")]
	[AddComponentMenu("Sons/Construction/ShutterStructure")]
	public class ShutterStructure : Structure
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00009A64 File Offset: 0x00007C64
		[Token(Token = "0x170003B0")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000FED")]
			[Address(RVA = "0xE59BC0", Offset = "0xE581C0", VA = "0x180E59BC0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003B1")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000FEE")]
			[Address(RVA = "0x2F08C20", Offset = "0x2F07220", VA = "0x182F08C20", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00009A7C File Offset: 0x00007C7C
		[Token(Token = "0x170003B2")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000FEF")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003B3")]
		public static Counter Counter
		{
			[Token(Token = "0x6000FF0")]
			[Address(RVA = "0x2F08C70", Offset = "0x2F07270", VA = "0x182F08C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00009A94 File Offset: 0x00007C94
		[Token(Token = "0x170003B4")]
		public bool IsClosed
		{
			[Token(Token = "0x6000FF1")]
			[Address(RVA = "0x2F08CC0", Offset = "0x2F072C0", VA = "0x182F08CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00009AAC File Offset: 0x00007CAC
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x2E9CA60", Offset = "0x2E9B060", VA = "0x182E9CA60", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x2F08CF0", Offset = "0x2F072F0", VA = "0x182F08CF0", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00009AC4 File Offset: 0x00007CC4
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void UpdateStimuli()
		{
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x2F08EB0", Offset = "0x2F074B0", VA = "0x182F08EB0", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x2F08F60", Offset = "0x2F07560", VA = "0x182F08F60")]
		public ShutterStructure()
		{
		}

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportedByDirs;
	}
}
