using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000228 RID: 552
	[Token(Token = "0x2000228")]
	[AddComponentMenu("Sons/Construction/StrutStructure")]
	public class StrutStructure : Structure, IBeamSupport, IStructure, IMonoBehaviour, ISuperStructureNode, IFreeFormStructureLinker
	{
		// Token: 0x060010C7 RID: 4295 RVA: 0x0000A394 File Offset: 0x00008594
		[Token(Token = "0x60010C7")]
		[Address(RVA = "0x2F173D0", Offset = "0x2F159D0", VA = "0x182F173D0", Slot = "105")]
		private Vector3 GetBeamSnapPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0000A3AC File Offset: 0x000085AC
		[Token(Token = "0x60010C8")]
		[Address(RVA = "0x2F17640", Offset = "0x2F15C40", VA = "0x182F17640", Slot = "106")]
		private bool TryGetBeamSnapPoint(Vector3 fromPoint, Vector3 nearPoint, out Vector3 snapPos, out Directions targetDir, out IBeamSupport targetSupport, out int supportQuality)
		{
			return default(bool);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "107")]
		private void LinkSupportedBeamsTogether(ref Directions supportDir, ref BeamDirections beamDir, BeamStructure beam)
		{
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0000A3C4 File Offset: 0x000085C4
		[Token(Token = "0x60010CA")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "108")]
		private bool CanHostNewBeam()
		{
			return default(bool);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010CB")]
		[Address(RVA = "0x2F176B0", Offset = "0x2F15CB0", VA = "0x182F176B0", Slot = "109")]
		private Directions[] GetAllBeamSnapPointsDirs()
		{
			return null;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0000A3DC File Offset: 0x000085DC
		[Token(Token = "0x60010CC")]
		[Address(RVA = "0x2F176F0", Offset = "0x2F15CF0", VA = "0x182F176F0", Slot = "110")]
		private bool TryGetBeamPlaceInfo(Directions targetDir, out Vector3 snapPos, out Vector3 placeAxis, out Vector3 lookAxis, out float lookAxisMaxDot, out bool lookupForwardStitching, out bool allowLeaning)
		{
			return default(bool);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0000A3F4 File Offset: 0x000085F4
		[Token(Token = "0x60010CD")]
		[Address(RVA = "0x2F17730", Offset = "0x2F15D30", VA = "0x182F17730", Slot = "111")]
		public Vector3 GetBeamPlaceAxisFromBeamDir(Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0000A40C File Offset: 0x0000860C
		[Token(Token = "0x60010CE")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "112")]
		private bool IsCompatibleWith(IBeamSupport otherSupport)
		{
			return default(bool);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0000A424 File Offset: 0x00008624
		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "113")]
		public bool AllowsLiftingBeam()
		{
			return default(bool);
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0000A43C File Offset: 0x0000863C
		[Token(Token = "0x170003DC")]
		public override ushort TypeID
		{
			[Token(Token = "0x60010D0")]
			[Address(RVA = "0x210AA70", Offset = "0x2109070", VA = "0x18210AA70", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x0000A454 File Offset: 0x00008654
		[Token(Token = "0x170003DD")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x60010D1")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003DE")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x60010D2")]
			[Address(RVA = "0x2F17770", Offset = "0x2F15D70", VA = "0x182F17770", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003DF")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x60010D3")]
			[Address(RVA = "0x2F177C0", Offset = "0x2F15DC0", VA = "0x182F177C0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003E0")]
		public BeamStructure Beam
		{
			[Token(Token = "0x60010D4")]
			[Address(RVA = "0x2F17810", Offset = "0x2F15E10", VA = "0x182F17810")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003E1")]
		public static Counter Counter
		{
			[Token(Token = "0x60010D5")]
			[Address(RVA = "0x2F17850", Offset = "0x2F15E50", VA = "0x182F17850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0000A46C File Offset: 0x0000866C
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x2F178A0", Offset = "0x2F15EA0", VA = "0x182F178A0", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0000A484 File Offset: 0x00008684
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x2F17BF0", Offset = "0x2F161F0", VA = "0x182F17BF0", Slot = "100")]
		public override bool IsSupportingStructure([Optional] IStructure exceptStructure, bool allowFallback = true)
		{
			return default(bool);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0000A49C File Offset: 0x0000869C
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x2F17CA0", Offset = "0x2F162A0", VA = "0x182F17CA0")]
		public bool IsBeamForwardSupported()
		{
			return default(bool);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0000A4B4 File Offset: 0x000086B4
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x2F17DD0", Offset = "0x2F163D0", VA = "0x182F17DD0")]
		public bool IsForwardBeamLeaningAgainstBeam()
		{
			return default(bool);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0000A4CC File Offset: 0x000086CC
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x2F180A0", Offset = "0x2F166A0", VA = "0x182F180A0", Slot = "101")]
		public override bool IsMissingSupport()
		{
			return default(bool);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0000A4E4 File Offset: 0x000086E4
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0000A4FC File Offset: 0x000086FC
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x2F180F0", Offset = "0x2F166F0", VA = "0x182F180F0", Slot = "76")]
		public override Quaternion CalcNextElementRotation(StructureElement elementPrefab)
		{
			return default(Quaternion);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0000A514 File Offset: 0x00008714
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x2F182D0", Offset = "0x2F168D0", VA = "0x182F182D0", Slot = "81")]
		public override bool TryGetRemoveableElement(Vector3 nearPos, out StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0000A52C File Offset: 0x0000872C
		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x2F18320", Offset = "0x2F16920", VA = "0x182F18320", Slot = "83")]
		public override bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x2F18420", Offset = "0x2F16A20", VA = "0x182F18420")]
		public StrutStructure()
		{
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010E1")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0000A544 File Offset: 0x00008744
		[Token(Token = "0x60010E4")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0000A55C File Offset: 0x0000875C
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x2F18690", Offset = "0x2F16C90", VA = "0x182F18690")]
		[CompilerGenerated]
		private bool <TryGetRemoveableElement>g__IsRequiredForMaxDroopingLevel|31_0()
		{
			return default(bool);
		}

		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x02000229 RID: 553
		[Token(Token = "0x2000229")]
		public static class Utils
		{
			// Token: 0x060010E6 RID: 4326 RVA: 0x0000A574 File Offset: 0x00008774
			[Token(Token = "0x60010E6")]
			[Address(RVA = "0x2F19210", Offset = "0x2F17810", VA = "0x182F19210")]
			public static Vector3 CalcStrutPosFromBeam(BeamStructure targetBeam, StructureElement StrutPrefab)
			{
				return default(Vector3);
			}

			// Token: 0x060010E7 RID: 4327 RVA: 0x0000A58C File Offset: 0x0000878C
			[Token(Token = "0x60010E7")]
			[Address(RVA = "0x2F19340", Offset = "0x2F17940", VA = "0x182F19340")]
			public static float CalcStrutHeightOffsetFromBeam(StructureElement StrutPrefab)
			{
				return 0f;
			}

			// Token: 0x060010E8 RID: 4328 RVA: 0x0000A5A4 File Offset: 0x000087A4
			[Token(Token = "0x60010E8")]
			[Address(RVA = "0x2F19380", Offset = "0x2F17980", VA = "0x182F19380")]
			public static Vector3 CalcStrutPosFromBeamForward(BeamStructure targetBeam, StructureElement StrutPrefab)
			{
				return default(Vector3);
			}
		}
	}
}
