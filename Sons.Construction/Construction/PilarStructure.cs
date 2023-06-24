using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Construction.Utils;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x20001D2")]
	[AddComponentMenu("Sons/Construction/PilarStructure")]
	public class PilarStructure : Structure, IDetachedPlacementStructure, IBeamSupport, IStructure, IMonoBehaviour, ISuperStructureNode, IElectricWireSupport, IFreeFormStructureLinker
	{
		// Token: 0x06000DBC RID: 3516 RVA: 0x0000878C File Offset: 0x0000698C
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x2ED8B70", Offset = "0x2ED7170", VA = "0x182ED8B70", Slot = "126")]
		public virtual Vector3 GetBeamSnapPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000087A4 File Offset: 0x000069A4
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x2ED8E90", Offset = "0x2ED7490", VA = "0x182ED8E90", Slot = "110")]
		private bool TryGetBeamSnapPoint(Vector3 fromPoint, Vector3 nearPoint, out Vector3 snapPos, out Directions targetDir, out IBeamSupport targetSupport, out int supportQuality)
		{
			return default(bool);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x2ED9250", Offset = "0x2ED7850", VA = "0x182ED9250", Slot = "111")]
		private void LinkSupportedBeamsTogether(ref Directions supportDir, ref BeamDirections beamDir, BeamStructure newBeam)
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x000087BC File Offset: 0x000069BC
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
		public bool HasNearbyBeamSnapPoint(Vector3 backPos, Vector3 forwardPos)
		{
			return default(bool);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x000087D4 File Offset: 0x000069D4
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "112")]
		private bool CanHostNewBeam()
		{
			return default(bool);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x2EDA660", Offset = "0x2ED8C60", VA = "0x182EDA660", Slot = "113")]
		private Directions[] GetAllBeamSnapPointsDirs()
		{
			return null;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000087EC File Offset: 0x000069EC
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x2EDA6F0", Offset = "0x2ED8CF0", VA = "0x182EDA6F0", Slot = "114")]
		private bool TryGetBeamPlaceInfo(Directions targetDir, out Vector3 snapPos, out Vector3 placeAxis, out Vector3 lookAxis, out float lookAxisMaxDot, out bool lookupForwardStitching, out bool allowLeaning)
		{
			return default(bool);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00008804 File Offset: 0x00006A04
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x2EDA9C0", Offset = "0x2ED8FC0", VA = "0x182EDA9C0", Slot = "115")]
		public Vector3 GetBeamPlaceAxisFromBeamDir(Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0000881C File Offset: 0x00006A1C
		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "116")]
		private bool IsCompatibleWith(IBeamSupport otherSupport)
		{
			return default(bool);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00008834 File Offset: 0x00006A34
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x2EDABA0", Offset = "0x2ED91A0", VA = "0x182EDABA0")]
		public bool TryGetUnusedFakePilarLeveledPos(out Vector3 leveledPos)
		{
			return default(bool);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0000884C File Offset: 0x00006A4C
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0x2EDAE90", Offset = "0x2ED9490", VA = "0x182EDAE90", Slot = "117")]
		public bool AllowsLiftingBeam()
		{
			return default(bool);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00008864 File Offset: 0x00006A64
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x2EDAF80", Offset = "0x2ED9580", VA = "0x182EDAF80")]
		private bool CheckFakePilarCanBeUsed()
		{
			return default(bool);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x0000887C File Offset: 0x00006A7C
		[Token(Token = "0x17000341")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000DC8")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000342")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000DC9")]
			[Address(RVA = "0x2EDB290", Offset = "0x2ED9890", VA = "0x182EDB290", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000343")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000DCA")]
			[Address(RVA = "0x2EDB2E0", Offset = "0x2ED98E0", VA = "0x182EDB2E0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00008894 File Offset: 0x00006A94
		[Token(Token = "0x17000344")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000DCB")]
			[Address(RVA = "0x15FFA90", Offset = "0x15FE090", VA = "0x1815FFA90", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000345")]
		public static Counter Counter
		{
			[Token(Token = "0x6000DCC")]
			[Address(RVA = "0x2EDB330", Offset = "0x2ED9930", VA = "0x182EDB330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x2EDB380", Offset = "0x2ED9980", VA = "0x182EDB380", Slot = "88")]
		public override string GetDirName(int dir)
		{
			return null;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000088AC File Offset: 0x00006AAC
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x2EDB3D0", Offset = "0x2ED99D0", VA = "0x182EDB3D0", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x000088C4 File Offset: 0x00006AC4
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x2EDB980", Offset = "0x2ED9F80", VA = "0x182EDB980")]
		public bool HasLinkedPerpendicularFloorSupportsSupportingFloor(Directions targetDir)
		{
			return default(bool);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000088DC File Offset: 0x00006ADC
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x2EDBCF0", Offset = "0x2EDA2F0", VA = "0x182EDBCF0", Slot = "102")]
		public override float GetStructuralResistanceFactor(int maxDepth)
		{
			return 0f;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x000088F4 File Offset: 0x00006AF4
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x2EDC070", Offset = "0x2EDA670", VA = "0x182EDC070", Slot = "97")]
		public override bool IsSupportingAny()
		{
			return default(bool);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0000890C File Offset: 0x00006B0C
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x2EDC170", Offset = "0x2EDA770", VA = "0x182EDC170", Slot = "100")]
		public override bool IsSupportingStructure([Optional] IStructure exceptStructure, bool allowFallbacks = true)
		{
			return default(bool);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00008924 File Offset: 0x00006B24
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x2EB6040", Offset = "0x2EB4640", VA = "0x182EB6040", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0000893C File Offset: 0x00006B3C
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x2EDC300", Offset = "0x2EDA900", VA = "0x182EDC300", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00008954 File Offset: 0x00006B54
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x2EDC5C0", Offset = "0x2EDABC0", VA = "0x182EDC5C0", Slot = "76")]
		public override Quaternion CalcNextElementRotation(StructureElement elementPrefab)
		{
			return default(Quaternion);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x2EDC710", Offset = "0x2EDAD10", VA = "0x182EDC710", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0000896C File Offset: 0x00006B6C
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x2EDC8D0", Offset = "0x2EDAED0", VA = "0x182EDC8D0", Slot = "81")]
		public override bool TryGetRemoveableElement(Vector3 nearPos, out StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00008984 File Offset: 0x00006B84
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x2EDCA20", Offset = "0x2EDB020", VA = "0x182EDCA20", Slot = "83")]
		public override bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0000899C File Offset: 0x00006B9C
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x2EDCCF0", Offset = "0x2EDB2F0", VA = "0x182EDCCF0")]
		private bool CheckPilarRequiredToPreventDrooping()
		{
			return default(bool);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x2EDCEA0", Offset = "0x2EDB4A0", VA = "0x182EDCEA0", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x2EDD4D0", Offset = "0x2EDBAD0", VA = "0x182EDD4D0", Slot = "65")]
		public override void OnLinkedStructuresChanged()
		{
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x2EDD510", Offset = "0x2EDBB10", VA = "0x182EDD510", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x000089B4 File Offset: 0x00006BB4
		[Token(Token = "0x17000346")]
		public bool IsOrientationFixed
		{
			[Token(Token = "0x6000DDD")]
			[Address(RVA = "0x2EDD520", Offset = "0x2EDBB20", VA = "0x182EDD520", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000347")]
		public Structure BackStructure
		{
			[Token(Token = "0x6000DDE")]
			[Address(RVA = "0x2225870", Offset = "0x2223E70", VA = "0x182225870")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000348")]
		public Structure ForwardStructure
		{
			[Token(Token = "0x6000DDF")]
			[Address(RVA = "0x22258A0", Offset = "0x2223EA0", VA = "0x1822258A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000349")]
		public Structure RightStructure
		{
			[Token(Token = "0x6000DE0")]
			[Address(RVA = "0x2225900", Offset = "0x2223F00", VA = "0x182225900")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700034A")]
		public Structure LeftStructure
		{
			[Token(Token = "0x6000DE1")]
			[Address(RVA = "0x22258D0", Offset = "0x2223ED0", VA = "0x1822258D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700034B")]
		public Structure UnderStructure
		{
			[Token(Token = "0x6000DE2")]
			[Address(RVA = "0x2225960", Offset = "0x2223F60", VA = "0x182225960")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000089CC File Offset: 0x00006BCC
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x2EDD8A0", Offset = "0x2EDBEA0", VA = "0x182EDD8A0", Slot = "118")]
		public bool CanHostNewElectricWire()
		{
			return default(bool);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x2EDD9F0", Offset = "0x2EDBFF0", VA = "0x182EDD9F0", Slot = "119")]
		public void GetPlaceInfo(out Vector3 pos, out Vector3 axis)
		{
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000089E4 File Offset: 0x00006BE4
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x9FA5F0", Offset = "0x9F8BF0", VA = "0x1809FA5F0", Slot = "120")]
		private Directions GetElectricWireDir()
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x2EDDB50", Offset = "0x2EDC150", VA = "0x182EDDB50", Slot = "124")]
		private void SetElectricWire(ElectricWireStructure electricWire)
		{
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000089FC File Offset: 0x00006BFC
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x2EDDB70", Offset = "0x2EDC170", VA = "0x182EDDB70", Slot = "125")]
		private bool TryGetElectricWire(out ElectricWireStructure electricWire)
		{
			return default(bool);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x2EDDC10", Offset = "0x2EDC210", VA = "0x182EDDC10", Slot = "121")]
		private Directions[] GetElectricWireSupportSiblingsDir()
		{
			return null;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x2EDDC60", Offset = "0x2EDC260", VA = "0x182EDDC60", Slot = "122")]
		private void GetElectricWireSupportAncestrySiblingsDir(IElectricWireSupport fromSupport, List<ElectricWireStructure> wireList)
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x2EDDD40", Offset = "0x2EDC340", VA = "0x182EDDD40", Slot = "123")]
		private Directions[] GetPowerSourceSupportSiblingsDir()
		{
			return null;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x2EDDD90", Offset = "0x2EDC390", VA = "0x182EDDD90")]
		public PilarStructure()
		{
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "107")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00008A14 File Offset: 0x00006C14
		[Token(Token = "0x6000DF1")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00008A2C File Offset: 0x00006C2C
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x2EDE410", Offset = "0x2EDCA10", VA = "0x182EDE410")]
		[CompilerGenerated]
		internal static bool <Construction.IBeamSupport.LinkSupportedBeamsTogether>g__TryLinkAbovePilar|2_0(BeamDirections beamBDir, BeamStructure beamB, BeamDirections beamADir, BeamStructure beamA)
		{
			return default(bool);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00008A44 File Offset: 0x00006C44
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x2EDE4F0", Offset = "0x2EDCAF0", VA = "0x182EDE4F0")]
		[CompilerGenerated]
		private bool <CheckPilarRequiredToPreventDrooping>g__AreAlignedBeamsAboveMaxDroopingLevel|41_0(Directions directions, Directions dirB1)
		{
			return default(bool);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x2EDF570", Offset = "0x2EDDB70", VA = "0x182EDF570")]
		[CompilerGenerated]
		private void <Construction.IElectricWireSupport.GetElectricWireSupportAncestrySiblingsDir>g__LookupWireOnBeamsUnder|63_0(ref PilarStructure.<>c__DisplayClass63_0 A_1)
		{
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x2EDFA90", Offset = "0x2EDE090", VA = "0x182EDFA90")]
		[CompilerGenerated]
		private void <Construction.IElectricWireSupport.GetElectricWireSupportAncestrySiblingsDir>g__LookupWireOnPilarAbove|63_1(ref PilarStructure.<>c__DisplayClass63_0 A_1)
		{
		}

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Directions[] NonOrientedBeamDirs;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Directions[] OrientedBeamDirs;

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly Directions[] LeftRightDirs;

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly Directions[] BackForwardDirs;

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly Directions[] ElectricWireSupportSiblingsDirs;

		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly Directions[] ElectricWireAncestrySupportSiblingsDirs;

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly Directions[] PowerSourceSupportSiblingsDirs;

		// Token: 0x020001D3 RID: 467
		[Token(Token = "0x20001D3")]
		public static class Utils
		{
			// Token: 0x06000DF6 RID: 3574 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000DF6")]
			[Address(RVA = "0x2EDFD80", Offset = "0x2EDE380", VA = "0x182EDFD80")]
			public static void LinkNewPilarWithSupportingBeams(bool atBack, IPilarSupport support, PilarStructure newPilar)
			{
			}

			// Token: 0x06000DF7 RID: 3575 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000DF7")]
			[Address(RVA = "0x2EE01D0", Offset = "0x2EDE7D0", VA = "0x182EE01D0")]
			public static void CalcExtremitiesToFitHeightGrid(float topHeight, Vector3 groundPos, StructureElement elementPrefab, out float topExtremityHeight, out float groundExtremityHeight)
			{
			}

			// Token: 0x06000DF8 RID: 3576 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000DF8")]
			[Address(RVA = "0x2EE0420", Offset = "0x2EDEA20", VA = "0x182EE0420")]
			public static void ScalePilarToFitHeightGrid(PilarStructure newPilarStructure, StructureElement elementPrefab, float topExtremityHeight, float groundExtremityHeight)
			{
			}

			// Token: 0x06000DF9 RID: 3577 RVA: 0x00008A5C File Offset: 0x00006C5C
			[Token(Token = "0x6000DF9")]
			[Address(RVA = "0x2EE0640", Offset = "0x2EDEC40", VA = "0x182EE0640")]
			public static float CalcQuartersToFitDistance(StructureElement elementPrefab, float distance)
			{
				return 0f;
			}

			// Token: 0x06000DFA RID: 3578 RVA: 0x00008A74 File Offset: 0x00006C74
			[Token(Token = "0x6000DFA")]
			[Address(RVA = "0x2EE0720", Offset = "0x2EDED20", VA = "0x182EE0720")]
			public static Vector3 CalcPilarPosFromBeamBack(BeamStructure targetBeam)
			{
				return default(Vector3);
			}

			// Token: 0x06000DFB RID: 3579 RVA: 0x00008A8C File Offset: 0x00006C8C
			[Token(Token = "0x6000DFB")]
			[Address(RVA = "0x2EE0800", Offset = "0x2EDEE00", VA = "0x182EE0800")]
			public static Vector3 CalcPilarPosFromBeamForward(BeamStructure targetBeam, StructureElement elementPrefab)
			{
				return default(Vector3);
			}

			// Token: 0x06000DFC RID: 3580 RVA: 0x00008AA4 File Offset: 0x00006CA4
			[Token(Token = "0x6000DFC")]
			[Address(RVA = "0x2EE0A20", Offset = "0x2EDF020", VA = "0x182EE0A20")]
			public static bool TryLookupSupportingGround(Vector3 placePosTop, float castVerticalOffset, StructureElement pilarPrefab, SuperStructure superStructure, out IPilarSupport supportingBeam, out Vector3 placePosition, out float groundHeight, out float topHeight, CastUtils.Filters filters)
			{
				return default(bool);
			}

			// Token: 0x06000DFD RID: 3581 RVA: 0x00008ABC File Offset: 0x00006CBC
			[Token(Token = "0x6000DFD")]
			[Address(RVA = "0x2EE0F00", Offset = "0x2EDF500", VA = "0x182EE0F00")]
			public static bool CalcBeamLiftingPilarPlacementInfo(TargetInfo targetInfo, StructureElement prefab, bool leveled, out Vector3 pilarPos, out IPilarSupport pilarSupport, out float topHeight, out float groundHeight, out StructureElement pilarElementPrefab)
			{
				return default(bool);
			}

			// Token: 0x06000DFE RID: 3582 RVA: 0x00008AD4 File Offset: 0x00006CD4
			[Token(Token = "0x6000DFE")]
			[Address(RVA = "0x2EE14D0", Offset = "0x2EDFAD0", VA = "0x182EE14D0")]
			public static Vector3 GetElementOffsetFromStructurePos(StructureElement elementPrefab)
			{
				return default(Vector3);
			}

			// Token: 0x06000DFF RID: 3583 RVA: 0x00008AEC File Offset: 0x00006CEC
			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0x2EE15A0", Offset = "0x2EDFBA0", VA = "0x182EE15A0")]
			public static bool LookupAndLinkBeamsAbove(PilarStructure pilar)
			{
				return default(bool);
			}

			// Token: 0x06000E00 RID: 3584 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000E00")]
			[Address(RVA = "0x2EE1E40", Offset = "0x2EE0440", VA = "0x182EE1E40")]
			[CompilerGenerated]
			internal static void <LinkNewPilarWithSupportingBeams>g__LinkPilarWithSupportingBeam|0_0(PilarStructure pilarStructure, IPilarSupport siblingSupport)
			{
			}
		}
	}
}
