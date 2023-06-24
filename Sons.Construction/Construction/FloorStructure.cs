using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	[AddComponentMenu("Sons/Construction/FloorStructure")]
	public class FloorStructure : Structure, ITargetablePlacement, IWallSupport, IStructure, IMonoBehaviour, ISuperStructureNode, IHangingBetweenSupports, ISolarPanelSupport, ITileCenter, IFreeFormStructureLinker
	{
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00007934 File Offset: 0x00005B34
		[Token(Token = "0x170002E7")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0xE51980", Offset = "0xE4FF80", VA = "0x180E51980", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0000794C File Offset: 0x00005B4C
		[Token(Token = "0x170002E8")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x22F5170", Offset = "0x22F3770", VA = "0x1822F5170", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002E9")]
		public virtual ITileSupport BackSupport
		{
			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x2EB3BE0", Offset = "0x2EB21E0", VA = "0x182EB3BE0", Slot = "121")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002EA")]
		public virtual ITileSupport ForwardSupport
		{
			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x2EB3C40", Offset = "0x2EB2240", VA = "0x182EB3C40", Slot = "122")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002EB")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x2EB3CA0", Offset = "0x2EB22A0", VA = "0x182EB3CA0", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002EC")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x2EB3CF0", Offset = "0x2EB22F0", VA = "0x182EB3CF0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00007964 File Offset: 0x00005B64
		[Token(Token = "0x170002ED")]
		protected virtual bool UseCeilingRounding
		{
			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002EE")]
		public static Counter Counter
		{
			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x2EB3D40", Offset = "0x2EB2340", VA = "0x182EB3D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x2EB3D90", Offset = "0x2EB2390", VA = "0x182EB3D90", Slot = "88")]
		public override string GetDirName(int dir)
		{
			return null;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x2E5E670", Offset = "0x2E5CC70", VA = "0x182E5E670")]
		public void SetStructureAtDir(FloorDirections direction, IStructure structure)
		{
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000BE0")]
		public T GetStructureAtDir<T>(FloorDirections direction) where T : class, IStructure
		{
			return null;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0000797C File Offset: 0x00005B7C
		[Token(Token = "0x6000BE1")]
		public bool TryGetStructureAtDir<T>(FloorDirections direction, out T structure) where T : class, IStructure
		{
			return default(bool);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00007994 File Offset: 0x00005B94
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x2EB3DE0", Offset = "0x2EB23E0", VA = "0x182EB3DE0")]
		public bool HasStructureAtDir(FloorDirections direction)
		{
			return default(bool);
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000079AC File Offset: 0x00005BAC
		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x2EB3E00", Offset = "0x2EB2400", VA = "0x182EB3E00", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000079C4 File Offset: 0x00005BC4
		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x2EB56F0", Offset = "0x2EB3CF0", VA = "0x182EB56F0", Slot = "71")]
		public override int CalcMaxElements(StructureElement floorPrefab)
		{
			return 0;
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000079DC File Offset: 0x00005BDC
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x2EB57A0", Offset = "0x2EB3DA0", VA = "0x182EB57A0", Slot = "124")]
		public virtual int CalcMissingElements(StructureElement floorPrefab)
		{
			return 0;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x2EB57F0", Offset = "0x2EB3DF0", VA = "0x182EB57F0", Slot = "79")]
		public override StructureElement AddElement(StructureElement elementPrefab, Vector3 worldPos)
		{
			return null;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x000079F4 File Offset: 0x00005BF4
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x2EB5D40", Offset = "0x2EB4340", VA = "0x182EB5D40", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00007A0C File Offset: 0x00005C0C
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x2EB5D90", Offset = "0x2EB4390", VA = "0x182EB5D90", Slot = "125")]
		protected virtual Vector3 GetElementUpAxis()
		{
			return default(Vector3);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x2EB5DF0", Offset = "0x2EB43F0", VA = "0x182EB5DF0", Slot = "106")]
		public void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 position, out Quaternion rotation, out float lengthScale)
		{
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x2E96DB0", Offset = "0x2E953B0", VA = "0x182E96DB0", Slot = "82")]
		public override StructureElement GetElementToRemove(Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00007A24 File Offset: 0x00005C24
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x2EB6040", Offset = "0x2EB4640", VA = "0x182EB6040", Slot = "126")]
		protected virtual int GetRepairableElements()
		{
			return 0;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x2EB60B0", Offset = "0x2EB46B0", VA = "0x182EB60B0", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x2EB6B20", Offset = "0x2EB5120", VA = "0x182EB6B20", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x2EB6B50", Offset = "0x2EB5150", VA = "0x182EB6B50", Slot = "64")]
		public override void OnElementsChangedClient()
		{
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x2EB6B20", Offset = "0x2EB5120", VA = "0x182EB6B20", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x2EB6B60", Offset = "0x2EB5160", VA = "0x182EB6B60", Slot = "61")]
		public override void OnDestroyingStructure()
		{
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x2EB6B90", Offset = "0x2EB5190", VA = "0x182EB6B90", Slot = "62")]
		public override void OnDestroyingStructureClient()
		{
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x2EB6BB0", Offset = "0x2EB51B0", VA = "0x182EB6BB0")]
		[ContextMenu("Refresh NavCut")]
		protected void RefreshNavCut()
		{
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00007A3C File Offset: 0x00005C3C
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x2EB6BE0", Offset = "0x2EB51E0", VA = "0x182EB6BE0")]
		private bool ShouldBlockNav()
		{
			return default(bool);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00007A54 File Offset: 0x00005C54
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x2EB7160", Offset = "0x2EB5760", VA = "0x182EB7160", Slot = "127")]
		protected virtual float ExtraNavCutHeight()
		{
			return 0f;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x2EB7170", Offset = "0x2EB5770", VA = "0x182EB7170", Slot = "104")]
		protected override NavMeshCutSetup CreateNavMeshCut()
		{
			return null;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x2EB7490", Offset = "0x2EB5A90", VA = "0x182EB7490")]
		private void RefreshSuperStructure()
		{
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00007A6C File Offset: 0x00005C6C
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x26E86D0", Offset = "0x26E6CD0", VA = "0x1826E86D0", Slot = "120")]
		public Vector3 CalcTileCenterPos()
		{
			return default(Vector3);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00007A84 File Offset: 0x00005C84
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x2EB7570", Offset = "0x2EB5B70", VA = "0x182EB7570", Slot = "114")]
		private bool CanHostNewSolarPanel()
		{
			return default(bool);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00007A9C File Offset: 0x00005C9C
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x6C1D40", Offset = "0x6C0340", VA = "0x1806C1D40", Slot = "115")]
		private Directions GetSolarPanelDir()
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x2EB7590", Offset = "0x2EB5B90", VA = "0x182EB7590", Slot = "117")]
		private void SetSolarPanel(SolarPanelStructure solarPanel)
		{
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00007AB4 File Offset: 0x00005CB4
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x2EB75B0", Offset = "0x2EB5BB0", VA = "0x182EB75B0", Slot = "118")]
		private bool TryGetSolarPanel(out SolarPanelStructure solarPanel)
		{
			return default(bool);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00007ACC File Offset: 0x00005CCC
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x2EB7630", Offset = "0x2EB5C30", VA = "0x182EB7630", Slot = "119")]
		private Vector3 GetSolarPanelSnapPos()
		{
			return default(Vector3);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x2EB77D0", Offset = "0x2EB5DD0", VA = "0x182EB77D0", Slot = "116")]
		private Directions[] GetElectricWireSupportSiblingsDir()
		{
			return null;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00007AE4 File Offset: 0x00005CE4
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x2EB7820", Offset = "0x2EB5E20", VA = "0x182EB7820")]
		private FloorDirections GetWallFloorDirection(Directions dir)
		{
			return FloorDirections.BackSupport;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00007AFC File Offset: 0x00005CFC
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x2EB7570", Offset = "0x2EB5B70", VA = "0x182EB7570", Slot = "107")]
		private bool CanHostNewWall()
		{
			return default(bool);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00007B14 File Offset: 0x00005D14
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x2EB78D0", Offset = "0x2EB5ED0", VA = "0x182EB78D0", Slot = "109")]
		private bool HasWallAtDir(Directions dir)
		{
			return default(bool);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00007B2C File Offset: 0x00005D2C
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x2EB7900", Offset = "0x2EB5F00", VA = "0x182EB7900", Slot = "110")]
		private bool TryGetWallAtDir(Directions dir, out WallStructure wall)
		{
			return default(bool);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x2EB79A0", Offset = "0x2EB5FA0", VA = "0x182EB79A0", Slot = "111")]
		private Directions[] GetAllWallSnapPointsDirs()
		{
			return null;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00007B44 File Offset: 0x00005D44
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x2EB87F0", Offset = "0x2EB6DF0", VA = "0x182EB87F0", Slot = "112")]
		private Directions GetWallDirForWallPos(Vector3 wallPos)
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00007B5C File Offset: 0x00005D5C
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x2EB8920", Offset = "0x2EB6F20", VA = "0x182EB8920", Slot = "113")]
		private bool TryGetWallPlacementInfo(Directions dir, StructureElement prefab, out Vector3 snapPos, out Vector3 placeAxis)
		{
			return default(bool);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x2EB9380", Offset = "0x2EB7980", VA = "0x182EB9380", Slot = "108")]
		private void SetWallAtDir(Directions dir, WallStructure wall)
		{
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x2EB93C0", Offset = "0x2EB79C0", VA = "0x182EB93C0")]
		public FloorStructure()
		{
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00007B74 File Offset: 0x00005D74
		[Token(Token = "0x6000C0B")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00007B8C File Offset: 0x00005D8C
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x2EB9930", Offset = "0x2EB7F30", VA = "0x182EB9930")]
		[CompilerGenerated]
		internal static float <ShouldBlockNav>g__GetGroundDistance|40_0(Vector3 pos)
		{
			return 0f;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x2EB9970", Offset = "0x2EB7F70", VA = "0x182EB9970")]
		[CompilerGenerated]
		private void <Construction.IWallSupport.GetAllWallSnapPointsDirs>g__CheckIfBeamIsLeaningAboveFloor|59_0(BeamStructure beam, ref FloorStructure.<>c__DisplayClass59_0 A_2)
		{
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x2EB9BB0", Offset = "0x2EB81B0", VA = "0x182EB9BB0")]
		[CompilerGenerated]
		private void <Construction.IWallSupport.GetAllWallSnapPointsDirs>g__ToggleAllowSide|59_1(bool onTheRight, ref FloorStructure.<>c__DisplayClass59_0 A_2)
		{
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00007BA4 File Offset: 0x00005DA4
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x2EB9BC0", Offset = "0x2EB81C0", VA = "0x182EB9BC0")]
		[CompilerGenerated]
		private bool <Construction.IWallSupport.TryGetWallPlacementInfo>g__HasPilarAtCorners|61_0(FloorDirections floorDirections, IPilarSupport pilarSupport)
		{
			return default(bool);
		}

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Directions[] ElectricWireSupportSiblingsDirs;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Directions[] WallSnaPointsDirs;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x28")]
		private static readonly Directions[] LeftWallSnaPointsDirs;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Directions[] RightWallSnaPointsDirs;

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Directions[] NoWallSnaPointsDirs;

		// Token: 0x02000189 RID: 393
		[Token(Token = "0x2000189")]
		public static class Stitching
		{
			// Token: 0x06000C10 RID: 3088 RVA: 0x00007BBC File Offset: 0x00005DBC
			[Token(Token = "0x6000C10")]
			public static bool LocateNearbyTileSupport<T>(T targetedSupport, bool targetingRightSide, bool isRampPlacement, out T support1, out T support2, out Vector3 placeAxis) where T : class, ITileSupport
			{
				return default(bool);
			}

			// Token: 0x06000C11 RID: 3089 RVA: 0x00007BD4 File Offset: 0x00005DD4
			[Token(Token = "0x6000C11")]
			private static bool LookupSupport<T>(Collider hitCollider, out T support2) where T : class, ITileSupport
			{
				return default(bool);
			}

			// Token: 0x06000C12 RID: 3090 RVA: 0x00007BEC File Offset: 0x00005DEC
			[Token(Token = "0x6000C12")]
			private static bool ValidateBeamToBeamSupportCompatibility<T>(T support1, T support2, bool isRampPlacement, out Vector3 placeAxis) where T : class, ITileSupport
			{
				return default(bool);
			}

			// Token: 0x06000C13 RID: 3091 RVA: 0x00007C04 File Offset: 0x00005E04
			[Token(Token = "0x6000C13")]
			private static bool ValidateBeamToWallSupportCompatibility<T>(T support1, T support2, out Vector3 placeAxis) where T : class, ITileSupport
			{
				return default(bool);
			}
		}

		// Token: 0x0200018A RID: 394
		[Token(Token = "0x200018A")]
		public static class Const
		{
			// Token: 0x04000724 RID: 1828
			[Token(Token = "0x4000724")]
			public const float OvershootFromSupportsHeight = 0.05f;
		}

		// Token: 0x0200018B RID: 395
		[Token(Token = "0x200018B")]
		public static class Utils
		{
			// Token: 0x06000C14 RID: 3092 RVA: 0x00007C1C File Offset: 0x00005E1C
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x2EB9D30", Offset = "0x2EB8330", VA = "0x182EB9D30")]
			public static Vector3 CalcFloorElementsOrientationAxis(ITileSupport support1, ITileSupport support2)
			{
				return default(Vector3);
			}

			// Token: 0x06000C15 RID: 3093 RVA: 0x00007C34 File Offset: 0x00005E34
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x2EB9FF0", Offset = "0x2EB85F0", VA = "0x182EB9FF0")]
			public static int CalcMaxElementsFromSupports(ITileSupport support1, ITileSupport support2, StructureElement floorPrefab, bool ceilingRounding, out float distanceBetweenPlanks)
			{
				return 0;
			}

			// Token: 0x06000C16 RID: 3094 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x2EBA4B0", Offset = "0x2EB8AB0", VA = "0x182EBA4B0")]
			public static void CalcClosestElements(ITileSupport support1, ITileSupport support2, StructureElement elementPrefab, Vector3 worldPos, Transform elementsRoot, bool secondClosest, bool ceilingRounding, out Vector3 closestElementPos, out Vector3 closestElementAxis, out float closestLengthScale, bool excludeAlreadyPlaced = true)
			{
			}

			// Token: 0x06000C17 RID: 3095 RVA: 0x00007C4C File Offset: 0x00005E4C
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x2EBAAF0", Offset = "0x2EB90F0", VA = "0x182EBAAF0")]
			public static int CalcElementPlacementMetrics(ITileSupport support1, ITileSupport support2, StructureElement elementPrefab, bool ceilingRounding, out Vector3 support1BackPos, out Vector3 support1ForwardPos, out Vector3 support2BackPos, out Vector3 support2ForwardPos)
			{
				return 0;
			}

			// Token: 0x06000C18 RID: 3096 RVA: 0x00007C64 File Offset: 0x00005E64
			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x2EBB3B0", Offset = "0x2EB99B0", VA = "0x182EBB3B0")]
			public static Vector3 CalcFloorPosFromSupports(ITileSupport support1, ITileSupport support2, StructureElement floorElementPrefab)
			{
				return default(Vector3);
			}

			// Token: 0x06000C19 RID: 3097 RVA: 0x00007C7C File Offset: 0x00005E7C
			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x2EBBA90", Offset = "0x2EBA090", VA = "0x182EBBA90")]
			public static bool IsFloorPlaceAxisValid(Vector3 placeAxis)
			{
				return default(bool);
			}

			// Token: 0x06000C1A RID: 3098 RVA: 0x00007C94 File Offset: 0x00005E94
			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x2EBBB20", Offset = "0x2EBA120", VA = "0x182EBBB20")]
			public static float GetFloorHeightDistanceFromSupport(StructureElement floorElementPrefab)
			{
				return 0f;
			}

			// Token: 0x06000C1B RID: 3099 RVA: 0x00007CAC File Offset: 0x00005EAC
			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x2EBBB20", Offset = "0x2EBA120", VA = "0x182EBBB20")]
			public static float GetElementHeightDistanceFromSupportTop(StructureElement floorElementPrefab)
			{
				return 0f;
			}

			// Token: 0x06000C1C RID: 3100 RVA: 0x00007CC4 File Offset: 0x00005EC4
			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0x2EBBB50", Offset = "0x2EBA150", VA = "0x182EBBB50")]
			public static bool ShouldSpinElement(int siblingIndex)
			{
				return default(bool);
			}

			// Token: 0x06000C1D RID: 3101 RVA: 0x00007CDC File Offset: 0x00005EDC
			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0x2EBBB60", Offset = "0x2EBA160", VA = "0x182EBBB60")]
			[CompilerGenerated]
			internal static bool <CalcClosestElements>g__ValidateSlotAvailability|5_0(Transform targetTr, float halfWidth, Vector3 elementPos)
			{
				return default(bool);
			}

			// Token: 0x04000725 RID: 1829
			[Token(Token = "0x4000725")]
			private const float AngleSaturation = 3f;

			// Token: 0x04000726 RID: 1830
			[Token(Token = "0x4000726")]
			private const float MaxAngle = 45f;

			// Token: 0x04000727 RID: 1831
			[Token(Token = "0x4000727")]
			private const float MaxAngleDistanceBetweenPlanksRatio = 0.3f;
		}
	}
}
