using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	public class StructurePartialCollapseProcessor : IStructureImpactProcessor
	{
		// Token: 0x06000361 RID: 865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
		public StructurePartialCollapseProcessor(float explosionForce)
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003764 File Offset: 0x00001964
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x2DC2720", Offset = "0x2DC0D20", VA = "0x182DC2720", Slot = "4")]
		public bool Process(StructureImpactProcessingData processingData)
		{
			return default(bool);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x2DC29F0", Offset = "0x2DC0FF0", VA = "0x182DC29F0")]
		private static void DestroyHighestElement(Structure structure, Vector3 attackSourcePos, float explosionForce)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x2DC2F00", Offset = "0x2DC1500", VA = "0x182DC2F00")]
		private static void DestroyClosestElement(Structure structure, Vector3 attackSourcePos, float explosionForce)
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000377C File Offset: 0x0000197C
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2DC3500", Offset = "0x2DC1B00", VA = "0x182DC3500")]
		[CompilerGenerated]
		internal static bool <Process>g__CheckDamageIsAboveTopBreakThreshold|2_0(ref StructurePartialCollapseProcessor.<>c__DisplayClass2_0 A_0)
		{
			return default(bool);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2DC3560", Offset = "0x2DC1B60", VA = "0x182DC3560")]
		[CompilerGenerated]
		internal static bool <Process>g__CheckTotalDamageSustainedReachedBreakThreshold|2_1(ref StructurePartialCollapseProcessor.<>c__DisplayClass2_0 A_0)
		{
			return default(bool);
		}

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x10")]
		private float _explosionForce;
	}
}
