using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000254 RID: 596
	[Token(Token = "0x2000254")]
	[AddComponentMenu("Sons/Construction/WallStructure")]
	public class WallStructure : Structure, IBeamSupport, IStructure, IMonoBehaviour, ISuperStructureNode, IHalfStairsSupport, IRampSupport, ITileSupport, ITileEdge, IFreeFormStructureLinker
	{
		// Token: 0x0600121B RID: 4635 RVA: 0x0000AEEC File Offset: 0x000090EC
		[Token(Token = "0x600121B")]
		[Address(RVA = "0x2F322B0", Offset = "0x2F308B0", VA = "0x182F322B0", Slot = "129")]
		public virtual bool CanTransformIntoApex()
		{
			return default(bool);
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x0000AF04 File Offset: 0x00009104
		[Token(Token = "0x17000417")]
		private Vector3 BackBeamSnapPos
		{
			[Token(Token = "0x600121C")]
			[Address(RVA = "0x2F32360", Offset = "0x2F30960", VA = "0x182F32360")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x0000AF1C File Offset: 0x0000911C
		[Token(Token = "0x17000418")]
		private Vector3 ForwardBeamSnapPos
		{
			[Token(Token = "0x600121D")]
			[Address(RVA = "0x2F32570", Offset = "0x2F30B70", VA = "0x182F32570")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0000AF34 File Offset: 0x00009134
		[Token(Token = "0x600121E")]
		[Address(RVA = "0x2F32780", Offset = "0x2F30D80", VA = "0x182F32780", Slot = "105")]
		private Vector3 GetBeamSnapPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0000AF4C File Offset: 0x0000914C
		[Token(Token = "0x600121F")]
		[Address(RVA = "0x2F17640", Offset = "0x2F15C40", VA = "0x182F17640", Slot = "106")]
		private bool TryGetBeamSnapPoint(Vector3 fromPoint, Vector3 nearPoint, out Vector3 snapPos, out Directions targetDir, out IBeamSupport targetSupport, out int supportQuality)
		{
			return default(bool);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001220")]
		[Address(RVA = "0x2F329B0", Offset = "0x2F30FB0", VA = "0x182F329B0", Slot = "107")]
		private void LinkSupportedBeamsTogether(ref Directions supportDir, ref BeamDirections beamDir, BeamStructure newBeam)
		{
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0000AF64 File Offset: 0x00009164
		[Token(Token = "0x6001221")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "108")]
		private bool CanHostNewBeam()
		{
			return default(bool);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001222")]
		[Address(RVA = "0x2F32B10", Offset = "0x2F31110", VA = "0x182F32B10", Slot = "109")]
		private Directions[] GetAllBeamSnapPointsDirs()
		{
			return null;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0000AF7C File Offset: 0x0000917C
		[Token(Token = "0x6001223")]
		[Address(RVA = "0x2F32B60", Offset = "0x2F31160", VA = "0x182F32B60")]
		public Directions GetOppositeSupportingDir(Directions dir)
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0000AF94 File Offset: 0x00009194
		[Token(Token = "0x6001224")]
		[Address(RVA = "0x2F32BA0", Offset = "0x2F311A0", VA = "0x182F32BA0", Slot = "110")]
		private bool TryGetBeamPlaceInfo(Directions targetDir, out Vector3 snapPos, out Vector3 placeAxis, out Vector3 lookAxis, out float lookAxisMaxDot, out bool lookupForwardStitching, out bool allowLeaning)
		{
			return default(bool);
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0000AFAC File Offset: 0x000091AC
		[Token(Token = "0x6001225")]
		[Address(RVA = "0x2F32D60", Offset = "0x2F31360", VA = "0x182F32D60", Slot = "111")]
		public Vector3 GetBeamPlaceAxisFromBeamDir(Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0000AFC4 File Offset: 0x000091C4
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "112")]
		private bool IsCompatibleWith(IBeamSupport otherSupport)
		{
			return default(bool);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0000AFDC File Offset: 0x000091DC
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "113")]
		public bool AllowsLiftingBeam()
		{
			return default(bool);
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0000AFF4 File Offset: 0x000091F4
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		private bool IsBlockedByHalfStairs(WallDirections wallDir, IHalfStairsSupport support1)
		{
			return default(bool);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001229")]
		[Address(RVA = "0x2F32F70", Offset = "0x2F31570", VA = "0x182F32F70", Slot = "126")]
		private void SetAboveTileEdge(Directions dir, ITileEdge tileEdge)
		{
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x0000B00C File Offset: 0x0000920C
		[Token(Token = "0x17000419")]
		public override ushort TypeID
		{
			[Token(Token = "0x600122A")]
			[Address(RVA = "0xB51A40", Offset = "0xB50040", VA = "0x180B51A40", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x0000B024 File Offset: 0x00009224
		[Token(Token = "0x1700041A")]
		public override bool StackedElements
		{
			[Token(Token = "0x600122B")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x0000B03C File Offset: 0x0000923C
		[Token(Token = "0x1700041B")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x600122C")]
			[Address(RVA = "0x210AA70", Offset = "0x2109070", VA = "0x18210AA70", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700041C")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x600122D")]
			[Address(RVA = "0x2F32F90", Offset = "0x2F31590", VA = "0x182F32F90", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700041D")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x600122E")]
			[Address(RVA = "0x2F32FE0", Offset = "0x2F315E0", VA = "0x182F32FE0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700041E")]
		public static Counter Counter
		{
			[Token(Token = "0x600122F")]
			[Address(RVA = "0x2F33030", Offset = "0x2F31630", VA = "0x182F33030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001230")]
		[Address(RVA = "0x2F33080", Offset = "0x2F31680", VA = "0x182F33080", Slot = "88")]
		public override string GetDirName(int dir)
		{
			return null;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001231")]
		[Address(RVA = "0x2E5E670", Offset = "0x2E5CC70", VA = "0x182E5E670")]
		public void SetStructureAtDir(WallDirections direction, IStructure structure)
		{
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0000B054 File Offset: 0x00009254
		[Token(Token = "0x6001232")]
		public bool TryGetStructureAtDir<T>(WallDirections forwardSupport, out T structure) where T : class, IStructure
		{
			return default(bool);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001233")]
		public T GetStructureAtDir<T>(WallDirections direction) where T : class, IStructure
		{
			return null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0000B06C File Offset: 0x0000926C
		[Token(Token = "0x6001234")]
		[Address(RVA = "0x2E5E690", Offset = "0x2E5CC90", VA = "0x182E5E690")]
		public bool HasStructureAtDir(WallDirections direction)
		{
			return default(bool);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0000B084 File Offset: 0x00009284
		[Token(Token = "0x6001235")]
		public bool HasStructureAtDir<T>(WallDirections direction) where T : class, IStructure
		{
			return default(bool);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0000B09C File Offset: 0x0000929C
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x2F330D0", Offset = "0x2F316D0", VA = "0x182F330D0", Slot = "102")]
		public override float GetStructuralResistanceFactor(int maxDepth)
		{
			return 0f;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0000B0B4 File Offset: 0x000092B4
		[Token(Token = "0x6001237")]
		[Address(RVA = "0x2F332A0", Offset = "0x2F318A0", VA = "0x182F332A0", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0000B0CC File Offset: 0x000092CC
		[Token(Token = "0x6001238")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "70")]
		public override int CalcMaxElements()
		{
			return 0;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0000B0E4 File Offset: 0x000092E4
		[Token(Token = "0x6001239")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0000B0FC File Offset: 0x000092FC
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x2F33D20", Offset = "0x2F32320", VA = "0x182F33D20", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0000B114 File Offset: 0x00009314
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x2F33E80", Offset = "0x2F32480", VA = "0x182F33E80", Slot = "81")]
		public override bool TryGetRemoveableElement(Vector3 nearPos, out StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0000B12C File Offset: 0x0000932C
		[Token(Token = "0x600123C")]
		[Address(RVA = "0x2F34370", Offset = "0x2F32970", VA = "0x182F34370", Slot = "83")]
		public override bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600123D")]
		[Address(RVA = "0x2F344D0", Offset = "0x2F32AD0", VA = "0x182F344D0", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600123E")]
		[Address(RVA = "0x2F34930", Offset = "0x2F32F30", VA = "0x182F34930", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600123F")]
		[Address(RVA = "0x2F34950", Offset = "0x2F32F50", VA = "0x182F34950", Slot = "64")]
		public override void OnElementsChangedClient()
		{
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001240")]
		[Address(RVA = "0x2F34930", Offset = "0x2F32F30", VA = "0x182F34930", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001241")]
		[Address(RVA = "0x2F34960", Offset = "0x2F32F60", VA = "0x182F34960", Slot = "61")]
		public override void OnDestroyingStructure()
		{
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001242")]
		[Address(RVA = "0x2F34990", Offset = "0x2F32F90", VA = "0x182F34990", Slot = "62")]
		public override void OnDestroyingStructureClient()
		{
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001243")]
		[Address(RVA = "0x2F349B0", Offset = "0x2F32FB0", VA = "0x182F349B0", Slot = "104")]
		protected override NavMeshCutSetup CreateNavMeshCut()
		{
			return null;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001244")]
		[Address(RVA = "0x2F34B50", Offset = "0x2F33150", VA = "0x182F34B50")]
		[ContextMenu("Refresh Stimuli/Nav")]
		public void RefreshStimuli()
		{
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0000B144 File Offset: 0x00009344
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x2EB6040", Offset = "0x2EB4640", VA = "0x182EB6040", Slot = "130")]
		public virtual int GetFullLineCount()
		{
			return 0;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0000B15C File Offset: 0x0000935C
		[Token(Token = "0x6001246")]
		[Address(RVA = "0x2F35B30", Offset = "0x2F34130", VA = "0x182F35B30")]
		private int GetWallDataForStimuli(out StructureElement lastElement, out bool blocksMovement)
		{
			return 0;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0000B174 File Offset: 0x00009374
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x2F35DA0", Offset = "0x2F343A0", VA = "0x182F35DA0")]
		public bool HasDoor()
		{
			return default(bool);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0000B18C File Offset: 0x0000938C
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x2F35E30", Offset = "0x2F34430", VA = "0x182F35E30")]
		public bool BlocksNav()
		{
			return default(bool);
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0000B1A4 File Offset: 0x000093A4
		[Token(Token = "0x6001249")]
		[Address(RVA = "0x2F35E60", Offset = "0x2F34460", VA = "0x182F35E60")]
		private bool HasWindow(out Transform windowTransform)
		{
			return default(bool);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0000B1BC File Offset: 0x000093BC
		[Token(Token = "0x600124A")]
		[Address(RVA = "0x2F360F0", Offset = "0x2F346F0", VA = "0x182F360F0")]
		private bool IsNearGround()
		{
			return default(bool);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x2F361E0", Offset = "0x2F347E0", VA = "0x182F361E0")]
		private void RefreshSuperStructure()
		{
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x2F36280", Offset = "0x2F34880", VA = "0x182F36280", Slot = "127")]
		private void GetBottomExtremities(out Vector3 backPos, out Vector3 forwardPos)
		{
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600124D")]
		[Address(RVA = "0x2F36500", Offset = "0x2F34B00", VA = "0x182F36500", Slot = "128")]
		private void GetTopExtremities(out Vector3 backPos, out Vector3 forwardPos)
		{
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0000B1D4 File Offset: 0x000093D4
		[Token(Token = "0x600124E")]
		[Address(RVA = "0x2F36780", Offset = "0x2F34D80", VA = "0x182F36780", Slot = "115")]
		public Vector3 CalcHalfStairsOffsetFromSupport(StructureElement halfStairsElementPrefab, Directions sideDir)
		{
			return default(Vector3);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0000B1EC File Offset: 0x000093EC
		[Token(Token = "0x600124F")]
		[Address(RVA = "0x2F368A0", Offset = "0x2F34EA0", VA = "0x182F368A0")]
		private static WallDirections GetHalfStairsDir(Directions direction)
		{
			return (WallDirections)0;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001250")]
		[Address(RVA = "0x2F368B0", Offset = "0x2F34EB0", VA = "0x182F368B0", Slot = "116")]
		public void SetHalfStairsAtDir(Directions direction, HalfStairsStructure halfStairs)
		{
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0000B204 File Offset: 0x00009404
		[Token(Token = "0x6001251")]
		[Address(RVA = "0x2F36930", Offset = "0x2F34F30", VA = "0x182F36930", Slot = "117")]
		public bool TryGetHalfStairsAtDir(Directions direction, out HalfStairsStructure halfStairs)
		{
			return default(bool);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0000B21C File Offset: 0x0000941C
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x2F369E0", Offset = "0x2F34FE0", VA = "0x182F369E0", Slot = "118")]
		public bool HasHalfStairsAtDir(Directions direction)
		{
			return default(bool);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0000B234 File Offset: 0x00009434
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x2F36A80", Offset = "0x2F35080", VA = "0x182F36A80", Slot = "119")]
		public bool TryCalcBottomStairsOptions(Directions sideDir, Directions bottomEndDir, out bool isBottomStairs)
		{
			return default(bool);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0000B24C File Offset: 0x0000944C
		[Token(Token = "0x6001254")]
		[Address(RVA = "0x2F36B60", Offset = "0x2F35160", VA = "0x182F36B60", Slot = "120")]
		public bool CalcCurvedStairsOptions(Directions sideDir, Directions bottomEndDir, out IHalfStairsSupport cornerSupport, out Directions cornerWallDir)
		{
			return default(bool);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0000B264 File Offset: 0x00009464
		[Token(Token = "0x6001255")]
		[Address(RVA = "0x2F368A0", Offset = "0x2F34EA0", VA = "0x182F368A0")]
		private static WallDirections GetWallRampDir(Directions direction)
		{
			return (WallDirections)0;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001256")]
		[Address(RVA = "0x2F36EA0", Offset = "0x2F354A0", VA = "0x182F36EA0", Slot = "121")]
		private void SetRampAtDir(Directions direction, RampStructure floor)
		{
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0000B27C File Offset: 0x0000947C
		[Token(Token = "0x6001257")]
		[Address(RVA = "0x2F36F20", Offset = "0x2F35520", VA = "0x182F36F20", Slot = "122")]
		private bool HasRampAtDir(Directions direction)
		{
			return default(bool);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0000B294 File Offset: 0x00009494
		[Token(Token = "0x6001258")]
		[Address(RVA = "0x2F36FC0", Offset = "0x2F355C0", VA = "0x182F36FC0", Slot = "124")]
		private bool CanHostNewRamp()
		{
			return default(bool);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0000B2AC File Offset: 0x000094AC
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x2F37060", Offset = "0x2F35660", VA = "0x182F37060", Slot = "123")]
		private bool TryGetRampAtDir(Directions direction, out RampStructure floor)
		{
			return default(bool);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600125A")]
		[Address(RVA = "0x2F37110", Offset = "0x2F35710", VA = "0x182F37110", Slot = "125")]
		private Directions[] GetRampDirs()
		{
			return null;
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600125B")]
		[Address(RVA = "0x2F37160", Offset = "0x2F35760", VA = "0x182F37160")]
		public WallStructure()
		{
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600125D")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600125E")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600125F")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0000B2C4 File Offset: 0x000094C4
		[Token(Token = "0x6001260")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x2F37710", Offset = "0x2F35D10", VA = "0x182F37710")]
		[CompilerGenerated]
		private void <Construction.IBeamSupport.LinkSupportedBeamsTogether>g__PerformLinking|7_0(BeamDirections beamSupportDir, ref WallStructure.<>c__DisplayClass7_0 A_2)
		{
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0000B2DC File Offset: 0x000094DC
		[Token(Token = "0x6001262")]
		[Address(RVA = "0x2F38D80", Offset = "0x2F37380", VA = "0x182F38D80")]
		[CompilerGenerated]
		internal static bool <Construction.IBeamSupport.TryGetBeamPlaceInfo>g__IsBlockedByCornerWall|11_0(WallDirections wallDir, Structure structure, Vector3 vector3, ref WallStructure.<>c__DisplayClass11_0 A_3)
		{
			return default(bool);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0000B2F4 File Offset: 0x000094F4
		[Token(Token = "0x6001263")]
		[Address(RVA = "0x2F39060", Offset = "0x2F37660", VA = "0x182F39060")]
		[CompilerGenerated]
		private bool <TryCalcBottomStairsOptions>g__ValidationDirection|72_0(ref bool isBottomStairs1, WallDirections wallDir, ref WallStructure.<>c__DisplayClass72_0 A_3)
		{
			return default(bool);
		}

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Directions[] WallBeamDirs;

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		public const int MaxElements = 5;

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400091E")]
		[FieldOffset(Offset = "0x20")]
		private static readonly WallDirections[] SiblingBackWallDirs;

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		[FieldOffset(Offset = "0x28")]
		private static readonly WallDirections[] SiblingForwardWallDirs;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x30")]
		private static readonly WallDirections[] SiblingWallDirs;

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Directions[] RampDirs;

		// Token: 0x02000255 RID: 597
		[Token(Token = "0x2000255")]
		public static class Utils
		{
			// Token: 0x06001264 RID: 4708 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001264")]
			[Address(RVA = "0x2F39700", Offset = "0x2F37D00", VA = "0x182F39700")]
			internal static void GetWallDirectionFromWall(ITileEdge from, ITileEdge to, out WallDirections fromDir, out WallDirections toDir)
			{
			}

			// Token: 0x06001265 RID: 4709 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001265")]
			[Address(RVA = "0x2F39760", Offset = "0x2F37D60", VA = "0x182F39760")]
			public static void GetSupportedBeamsDirs(bool atBack, out WallDirections dirFrom, out WallDirections dirTo)
			{
			}

			// Token: 0x06001266 RID: 4710 RVA: 0x0000B30C File Offset: 0x0000950C
			[Token(Token = "0x6001266")]
			[Address(RVA = "0x2F39790", Offset = "0x2F37D90", VA = "0x182F39790")]
			public static bool HasSiblingCompleteWallWithBeam(WallStructure wall, bool atBack)
			{
				return default(bool);
			}

			// Token: 0x06001267 RID: 4711 RVA: 0x0000B324 File Offset: 0x00009524
			[Token(Token = "0x6001267")]
			[Address(RVA = "0x2F398D0", Offset = "0x2F37ED0", VA = "0x182F398D0")]
			[CompilerGenerated]
			internal static WallDirections <GetWallDirectionFromWall>g__CalcWallDir|0_0(ITileEdge from, ITileEdge to)
			{
				return (WallDirections)0;
			}
		}
	}
}
