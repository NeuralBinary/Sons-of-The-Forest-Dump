using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000246 RID: 582
	[Token(Token = "0x2000246")]
	[AddComponentMenu("Sons/Construction/TreeStructure")]
	public class TreeStructure : Structure, IBeamSupport, IStructure, IMonoBehaviour, ISuperStructureNode, IWorldLocatorStateCallback
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x0000AA9C File Offset: 0x00008C9C
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "105")]
		public Vector3 GetBeamSnapPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		[Token(Token = "0x60011AC")]
		[Address(RVA = "0x2F28280", Offset = "0x2F26880", VA = "0x182F28280", Slot = "106")]
		public bool TryGetBeamSnapPoint(Vector3 fromPoint, Vector3 nearPoint, out Vector3 snapPos, out Directions targetDir, out IBeamSupport targetSupport, out int supportQuality)
		{
			return default(bool);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011AD")]
		[Address(RVA = "0x2F28610", Offset = "0x2F26C10", VA = "0x182F28610", Slot = "107")]
		public void LinkSupportedBeamsTogether(ref Directions supportDir, ref BeamDirections beamDir, BeamStructure newBeam)
		{
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0000AACC File Offset: 0x00008CCC
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "108")]
		private bool CanHostNewBeam()
		{
			return default(bool);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011AF")]
		[Address(RVA = "0x2F29420", Offset = "0x2F27A20", VA = "0x182F29420", Slot = "109")]
		private Directions[] GetAllBeamSnapPointsDirs()
		{
			return null;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		[Token(Token = "0x60011B0")]
		[Address(RVA = "0x2F29470", Offset = "0x2F27A70", VA = "0x182F29470", Slot = "110")]
		private bool TryGetBeamPlaceInfo(Directions targetDir, out Vector3 snapPos, out Vector3 placeAxis, out Vector3 lookAxis, out float lookAxisMaxDot, out bool lookupForwardStitching, out bool allowLeaning)
		{
			return default(bool);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0000AAFC File Offset: 0x00008CFC
		[Token(Token = "0x60011B1")]
		[Address(RVA = "0x2F296D0", Offset = "0x2F27CD0", VA = "0x182F296D0", Slot = "111")]
		public Vector3 GetBeamPlaceAxisFromBeamDir(Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0000AB14 File Offset: 0x00008D14
		[Token(Token = "0x60011B2")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "112")]
		private bool IsCompatibleWith(IBeamSupport otherSupport)
		{
			return default(bool);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0000AB2C File Offset: 0x00008D2C
		[Token(Token = "0x60011B3")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "113")]
		public bool AllowsLiftingBeam()
		{
			return default(bool);
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x0000AB44 File Offset: 0x00008D44
		[Token(Token = "0x1700040A")]
		public override ushort TypeID
		{
			[Token(Token = "0x60011B4")]
			[Address(RVA = "0x2F1AFB0", Offset = "0x2F195B0", VA = "0x182F1AFB0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700040B")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x60011B5")]
			[Address(RVA = "0x2F29820", Offset = "0x2F27E20", VA = "0x182F29820", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700040C")]
		public static Counter Counter
		{
			[Token(Token = "0x60011B6")]
			[Address(RVA = "0x2F29870", Offset = "0x2F27E70", VA = "0x182F29870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0000AB5C File Offset: 0x00008D5C
		[Token(Token = "0x60011B7")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0000AB74 File Offset: 0x00008D74
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0000AB8C File Offset: 0x00008D8C
		[Token(Token = "0x60011B9")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x2F298C0", Offset = "0x2F27EC0", VA = "0x182F298C0", Slot = "85")]
		public override float CalcBottomHeight()
		{
			return 0f;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0000ABBC File Offset: 0x00008DBC
		[Token(Token = "0x60011BB")]
		[Address(RVA = "0x2F298C0", Offset = "0x2F27EC0", VA = "0x182F298C0", Slot = "84")]
		public override float CalcTopHeight()
		{
			return 0f;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011BC")]
		[Address(RVA = "0x2F29980", Offset = "0x2F27F80", VA = "0x182F29980", Slot = "65")]
		public override void OnLinkedStructuresChanged()
		{
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011BD")]
		[Address(RVA = "0x2EDD510", Offset = "0x2EDBB10", VA = "0x182EDD510", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011BE")]
		[Address(RVA = "0x2F29A40", Offset = "0x2F28040", VA = "0x182F29A40", Slot = "56")]
		protected override void Awake()
		{
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011BF")]
		[Address(RVA = "0x2F29BD0", Offset = "0x2F281D0", VA = "0x182F29BD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C0")]
		[Address(RVA = "0x2F29CE0", Offset = "0x2F282E0", VA = "0x182F29CE0")]
		public void InitFromTreeTransform(Transform tree)
		{
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C1")]
		[Address(RVA = "0x2F29D60", Offset = "0x2F28360", VA = "0x182F29D60")]
		public void InitFromLocatorId(WorldLocatorId locatorId)
		{
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x2F29EE0", Offset = "0x2F284E0", VA = "0x182F29EE0", Slot = "114")]
		private void StateChanged(WorldObjectState newState)
		{
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x2F29FA0", Offset = "0x2F285A0", VA = "0x182F29FA0")]
		public void DeserializeData(TreeStructure.SaveData data)
		{
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		public TreeStructure.SaveData GetSerializedData()
		{
			return null;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x2F29FC0", Offset = "0x2F285C0", VA = "0x182F29FC0")]
		public TreeStructure()
		{
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011C8")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011C9")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		[Token(Token = "0x60011CA")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0000ABEC File Offset: 0x00008DEC
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0x2F2A2B0", Offset = "0x2F288B0", VA = "0x182F2A2B0")]
		[CompilerGenerated]
		internal static bool <LinkSupportedBeamsTogether>g__TryLinkAbovePilar|2_0(BeamDirections beamBDir, BeamStructure beamB, BeamDirections beamADir, BeamStructure beamA)
		{
			return default(bool);
		}

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Directions[] BeamDirs;

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		[FieldOffset(Offset = "0x40")]
		private TreeStructure.SaveData _treeData;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x02000247 RID: 583
		[Token(Token = "0x2000247")]
		[Serializable]
		public class SaveData
		{
			// Token: 0x060011CC RID: 4556 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60011CC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SaveData()
			{
			}

			// Token: 0x04000908 RID: 2312
			[Token(Token = "0x4000908")]
			[FieldOffset(Offset = "0x10")]
			public WorldLocatorId _locatorId;
		}
	}
}
