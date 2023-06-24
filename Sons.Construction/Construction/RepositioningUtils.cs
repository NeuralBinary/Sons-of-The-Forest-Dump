using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000266 RID: 614
	[Token(Token = "0x2000266")]
	public static class RepositioningUtils
	{
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000425")]
		public static ConstructionManager Manager
		{
			[Token(Token = "0x60012B1")]
			[Address(RVA = "0x2F3FCB0", Offset = "0x2F3E2B0", VA = "0x182F3FCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012B2")]
			[Address(RVA = "0x2F3FD00", Offset = "0x2F3E300", VA = "0x182F3FD00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000426")]
		private static RepositioningUtils.RepositionOperation StartingOperation
		{
			[Token(Token = "0x60012B3")]
			[Address(RVA = "0x2F3FDB0", Offset = "0x2F3E3B0", VA = "0x182F3FDB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012B4")]
			[Address(RVA = "0x2F3FE00", Offset = "0x2F3E400", VA = "0x182F3FE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x2F3FEB0", Offset = "0x2F3E4B0", VA = "0x182F3FEB0")]
		public static void CascadeChangeToSupportedStructures(List<Structure> initialStructures)
		{
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x2F403E0", Offset = "0x2F3E9E0", VA = "0x182F403E0")]
		private static IEnumerator CascadeRoutine(List<Structure> initialStructures)
		{
			return null;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x2F40470", Offset = "0x2F3EA70", VA = "0x182F40470")]
		public static void DestroyAndCascadeChangeToSupportedStructures(Structure initialStructure)
		{
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x2F408B0", Offset = "0x2F3EEB0", VA = "0x182F408B0")]
		private static IEnumerator DestroyAndCascadeRoutine(Structure initialStructure)
		{
			return null;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x2F40940", Offset = "0x2F3EF40", VA = "0x182F40940")]
		private static IEnumerator ProcessStructures(RepositioningUtils.RepositionOperation op, int remainingDelayedRepositionings)
		{
			return null;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x2F40A00", Offset = "0x2F3F000", VA = "0x182F40A00")]
		private static void LoadLinkedStructureForProcessing(RepositioningUtils.RepositionOperation op, Structure structure, bool canUpdate)
		{
		}

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x10")]
		private static int OpId;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x18")]
		private static List<float> LastPickupSpawns;

		// Token: 0x02000267 RID: 615
		[Token(Token = "0x2000267")]
		public class RepositionOperation
		{
			// Token: 0x060012BC RID: 4796 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60012BC")]
			[Address(RVA = "0x2F40D60", Offset = "0x2F3F360", VA = "0x182F40D60")]
			public void Dispose()
			{
			}

			// Token: 0x060012BD RID: 4797 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60012BD")]
			[Address(RVA = "0x2F40E90", Offset = "0x2F3F490", VA = "0x182F40E90")]
			public RepositionOperation()
			{
			}

			// Token: 0x04000940 RID: 2368
			[Token(Token = "0x4000940")]
			[FieldOffset(Offset = "0x10")]
			public int Id;

			// Token: 0x04000941 RID: 2369
			[Token(Token = "0x4000941")]
			[FieldOffset(Offset = "0x18")]
			public readonly HashSet<Structure> processed;

			// Token: 0x04000942 RID: 2370
			[Token(Token = "0x4000942")]
			[FieldOffset(Offset = "0x20")]
			public readonly List<Structure> toProcess;

			// Token: 0x04000943 RID: 2371
			[Token(Token = "0x4000943")]
			[FieldOffset(Offset = "0x28")]
			public readonly Queue<Structure> toDestroy;

			// Token: 0x04000944 RID: 2372
			[Token(Token = "0x4000944")]
			[FieldOffset(Offset = "0x30")]
			public readonly ElementRepositionAnimationTool repositioningTool;
		}
	}
}
