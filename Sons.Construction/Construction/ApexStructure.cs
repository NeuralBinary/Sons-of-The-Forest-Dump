using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	[AddComponentMenu("Sons/Construction/ApexStructure")]
	public class ApexStructure : Structure, IBeamSupport, IStructure, IMonoBehaviour, ISuperStructureNode, IFreeFormStructureLinker
	{
		// Token: 0x06000839 RID: 2105 RVA: 0x000053CC File Offset: 0x000035CC
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x2E557A0", Offset = "0x2E53DA0", VA = "0x182E557A0", Slot = "105")]
		private Vector3 GetBeamSnapPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000053E4 File Offset: 0x000035E4
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x2E55800", Offset = "0x2E53E00", VA = "0x182E55800", Slot = "106")]
		private bool TryGetBeamSnapPoint(Vector3 fromPoint, Vector3 nearPoint, out Vector3 snapPos, out Directions targetDir, out IBeamSupport targetSupport, out int supportQuality)
		{
			return default(bool);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x2E55BA0", Offset = "0x2E541A0", VA = "0x182E55BA0", Slot = "107")]
		private void LinkSupportedBeamsTogether(ref Directions supportDir, ref BeamDirections beamDir, BeamStructure beam)
		{
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000053FC File Offset: 0x000035FC
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "108")]
		private bool CanHostNewBeam()
		{
			return default(bool);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x2E55D90", Offset = "0x2E54390", VA = "0x182E55D90", Slot = "109")]
		private Directions[] GetAllBeamSnapPointsDirs()
		{
			return null;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00005414 File Offset: 0x00003614
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x2E55DE0", Offset = "0x2E543E0", VA = "0x182E55DE0", Slot = "110")]
		private bool TryGetBeamPlaceInfo(Directions targetDir, out Vector3 snapPos, out Vector3 placeAxis, out Vector3 lookAxis, out float lookAxisMaxDot, out bool lookupForwardStitching, out bool allowLeaning)
		{
			return default(bool);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0000542C File Offset: 0x0000362C
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x2E55EC0", Offset = "0x2E544C0", VA = "0x182E55EC0", Slot = "111")]
		public Vector3 GetBeamPlaceAxisFromBeamDir(Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00005444 File Offset: 0x00003644
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x2E56130", Offset = "0x2E54730", VA = "0x182E56130", Slot = "112")]
		private bool IsCompatibleWith(IBeamSupport otherSupport)
		{
			return default(bool);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0000545C File Offset: 0x0000365C
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "113")]
		public bool AllowsLiftingBeam()
		{
			return default(bool);
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00005474 File Offset: 0x00003674
		[Token(Token = "0x1700025C")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x15FFA90", Offset = "0x15FE090", VA = "0x1815FFA90", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x0000548C File Offset: 0x0000368C
		[Token(Token = "0x1700025D")]
		public override bool StackedElements
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000054A4 File Offset: 0x000036A4
		[Token(Token = "0x1700025E")]
		public bool IsSupporting
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x2E56410", Offset = "0x2E54A10", VA = "0x182E56410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700025F")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x2E56430", Offset = "0x2E54A30", VA = "0x182E56430", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000260")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x2E56480", Offset = "0x2E54A80", VA = "0x182E56480", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000261")]
		public static Counter Counter
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x2E564D0", Offset = "0x2E54AD0", VA = "0x182E564D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000054BC File Offset: 0x000036BC
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x2E56520", Offset = "0x2E54B20", VA = "0x182E56520", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000054D4 File Offset: 0x000036D4
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000054EC File Offset: 0x000036EC
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x2E56600", Offset = "0x2E54C00", VA = "0x182E56600", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00005504 File Offset: 0x00003704
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2E56800", Offset = "0x2E54E00", VA = "0x182E56800", Slot = "81")]
		public override bool TryGetRemoveableElement(Vector3 nearPos, out StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0000551C File Offset: 0x0000371C
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x2E56920", Offset = "0x2E54F20", VA = "0x182E56920", Slot = "83")]
		public override bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x2E56AB0", Offset = "0x2E550B0", VA = "0x182E56AB0", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x2E56F10", Offset = "0x2E55510", VA = "0x182E56F10")]
		public ApexStructure()
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00005534 File Offset: 0x00003734
		[Token(Token = "0x6000853")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Directions[] BeamDirs;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		public const int MaxElements = 5;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x0200012D RID: 301
		[Token(Token = "0x200012D")]
		public static class Utils
		{
			// Token: 0x06000854 RID: 2132 RVA: 0x0000554C File Offset: 0x0000374C
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x2E57230", Offset = "0x2E55830", VA = "0x182E57230")]
			internal static Vector3 CalcApexOnBeamSnapPos(StructureElement beamElement, StructureElement apexPrefab)
			{
				return default(Vector3);
			}
		}
	}
}
