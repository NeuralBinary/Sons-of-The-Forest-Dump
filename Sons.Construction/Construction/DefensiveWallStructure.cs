using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	[AddComponentMenu("Sons/Construction/DefensiveWallStructure")]
	public class DefensiveWallStructure : Structure, ITargetablePlacement, ISiegeStructure, IBeamSupport, IStructure, IMonoBehaviour, ISuperStructureNode, IFreeFormStructureLinker
	{
		// Token: 0x06000A59 RID: 2649 RVA: 0x00006BB4 File Offset: 0x00004DB4
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x2E96810", Offset = "0x2E94E10", VA = "0x182E96810", Slot = "107")]
		private Vector3 GetBeamSnapPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00006BCC File Offset: 0x00004DCC
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x2E96880", Offset = "0x2E94E80", VA = "0x182E96880", Slot = "108")]
		private bool TryGetBeamSnapPoint(Vector3 fromPoint, Vector3 nearPoint, out Vector3 snapPos, out Directions targetDir, out IBeamSupport targetSupport, out int supportQuality)
		{
			return default(bool);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "109")]
		private void LinkSupportedBeamsTogether(ref Directions supportDir, ref BeamDirections beamDir, BeamStructure beam)
		{
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00006BE4 File Offset: 0x00004DE4
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "110")]
		private bool CanHostNewBeam()
		{
			return default(bool);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x2E968F0", Offset = "0x2E94EF0", VA = "0x182E968F0", Slot = "111")]
		private Directions[] GetAllBeamSnapPointsDirs()
		{
			return null;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00006BFC File Offset: 0x00004DFC
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x2E96930", Offset = "0x2E94F30", VA = "0x182E96930", Slot = "112")]
		private bool TryGetBeamPlaceInfo(Directions targetDir, out Vector3 snapPos, out Vector3 placeAxis, out Vector3 lookAxis, out float lookAxisMaxDot, out bool lookupForwardStitching, out bool allowLeaning)
		{
			return default(bool);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00006C14 File Offset: 0x00004E14
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x2E96970", Offset = "0x2E94F70", VA = "0x182E96970", Slot = "113")]
		public Vector3 GetBeamPlaceAxisFromBeamDir(Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00006C2C File Offset: 0x00004E2C
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "114")]
		private bool IsCompatibleWith(IBeamSupport otherSupport)
		{
			return default(bool);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00006C44 File Offset: 0x00004E44
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "115")]
		public bool AllowsLiftingBeam()
		{
			return default(bool);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002A3")]
		public static Counter Counter
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x2E969B0", Offset = "0x2E94FB0", VA = "0x182E969B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00006C5C File Offset: 0x00004E5C
		[Token(Token = "0x170002A4")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x22F41B0", Offset = "0x22F27B0", VA = "0x1822F41B0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002A5")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x2E96A00", Offset = "0x2E95000", VA = "0x182E96A00", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00006C74 File Offset: 0x00004E74
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x2E96A50", Offset = "0x2E95050", VA = "0x182E96A50", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x2E96A90", Offset = "0x2E95090", VA = "0x182E96A90", Slot = "79")]
		public override StructureElement AddElement(StructureElement elementPrefab, Vector3 worldPos)
		{
			return null;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x2E96DB0", Offset = "0x2E953B0", VA = "0x182E96DB0", Slot = "82")]
		public override StructureElement GetElementToRemove(Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x2E96DE0", Offset = "0x2E953E0", VA = "0x182E96DE0", Slot = "106")]
		public void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 pos, out Quaternion rot, out float lengthScale)
		{
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00006C8C File Offset: 0x00004E8C
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "70")]
		public override int CalcMaxElements()
		{
			return 0;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00006CA4 File Offset: 0x00004EA4
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x2E96E20", Offset = "0x2E95420", VA = "0x182E96E20", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x2E96E20", Offset = "0x2E95420", VA = "0x182E96E20", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x2E96E60", Offset = "0x2E95460", VA = "0x182E96E60", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x2E97240", Offset = "0x2E95840", VA = "0x182E97240", Slot = "104")]
		protected override NavMeshCutSetup CreateNavMeshCut()
		{
			return null;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x2E97710", Offset = "0x2E95D10", VA = "0x182E97710")]
		private void AddStructureStimuliToWall()
		{
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x2E96E20", Offset = "0x2E95420", VA = "0x182E96E20")]
		private void RefreshStimuli()
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x2E97D70", Offset = "0x2E96370", VA = "0x182E97D70")]
		public DefensiveWallStructure()
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00006CBC File Offset: 0x00004EBC
		[Token(Token = "0x6000A77")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		public const int MaxElements = 5;

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x0200015E RID: 350
		[Token(Token = "0x200015E")]
		public static class Utils
		{
			// Token: 0x06000A78 RID: 2680 RVA: 0x00006CD4 File Offset: 0x00004ED4
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x2E97F50", Offset = "0x2E96550", VA = "0x182E97F50")]
			internal static Vector3 CalcDefensiveWallSnapPosFromElement(StructureElement targetElement, Vector3 lookAtPos, StructureElement dwPrefab)
			{
				return default(Vector3);
			}

			// Token: 0x06000A79 RID: 2681 RVA: 0x00006CEC File Offset: 0x00004EEC
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x2E98170", Offset = "0x2E96770", VA = "0x182E98170")]
			public static bool IsCloserToFirstVSLastElement(Structure structure, Vector3 hitPoint, out StructureElement closestElement)
			{
				return default(bool);
			}

			// Token: 0x06000A7A RID: 2682 RVA: 0x00006D04 File Offset: 0x00004F04
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x2E98510", Offset = "0x2E96B10", VA = "0x182E98510")]
			public static int CalculateSiblingIndex(Structure structure, Vector3 hitPoint)
			{
				return 0;
			}

			// Token: 0x06000A7B RID: 2683 RVA: 0x00006D1C File Offset: 0x00004F1C
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x2E98880", Offset = "0x2E96E80", VA = "0x182E98880")]
			public static Vector3 GetBeamSnapPos(DefensiveWallStructure targetDw, Directions dir)
			{
				return default(Vector3);
			}
		}
	}
}
