using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	[AddComponentMenu("Sons/Construction/BeamStructure")]
	public class BeamStructure : Structure, IFloorSupport, ITileSupport, IStructure, IMonoBehaviour, ISuperStructureNode, IRampSupport, IBeamSupport, IPilarSupport, IApexSupport, IWallSupport, IBridgeRopeSupport, IClimbRopeSupport, ISingleStepSupport, IElectricWireSupport, ITileEdge, IFreeFormStructureLinker
	{
		// Token: 0x0600087A RID: 2170 RVA: 0x000056B4 File Offset: 0x000038B4
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2E5BDB0", Offset = "0x2E5A3B0", VA = "0x182E5BDB0", Slot = "137")]
		private bool CanHostNewApex()
		{
			return default(bool);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x2E5BE30", Offset = "0x2E5A430", VA = "0x182E5BE30", Slot = "138")]
		private void SetApex(ApexStructure apex)
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000056CC File Offset: 0x000038CC
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x2E5BE50", Offset = "0x2E5A450", VA = "0x182E5BE50", Slot = "139")]
		private bool TryGetApex(out ApexStructure apex)
		{
			return default(bool);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000056E4 File Offset: 0x000038E4
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2E5BED0", Offset = "0x2E5A4D0", VA = "0x182E5BED0", Slot = "140")]
		private Vector3 GetApexSnapPos(StructureElement apexPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000056FC File Offset: 0x000038FC
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x2E5BF20", Offset = "0x2E5A520", VA = "0x182E5BF20")]
		public Vector3 GetForwardApexPosition(StructureElement beamPrefab, StructureElement apexPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00005714 File Offset: 0x00003914
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x2E5C220", Offset = "0x2E5A820", VA = "0x182E5C220", Slot = "120")]
		private bool CanHostNewBeam()
		{
			return default(bool);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x2E5C2C0", Offset = "0x2E5A8C0", VA = "0x182E5C2C0", Slot = "121")]
		private Directions[] GetAllBeamSnapPointsDirs()
		{
			return null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0000572C File Offset: 0x0000392C
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x2E5C430", Offset = "0x2E5AA30", VA = "0x182E5C430", Slot = "122")]
		private bool TryGetBeamPlaceInfo(Directions targetDir, out Vector3 snapPos, out Vector3 placeAxis, out Vector3 lookAxis, out float lookAxisMaxDot, out bool lookupForwardStitching, out bool allowLeaning)
		{
			return default(bool);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00005744 File Offset: 0x00003944
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x2E5C870", Offset = "0x2E5AE70", VA = "0x182E5C870", Slot = "123")]
		public Vector3 GetBeamPlaceAxisFromBeamDir(Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0000575C File Offset: 0x0000395C
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "124")]
		private bool IsCompatibleWith(IBeamSupport otherSupport)
		{
			return default(bool);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00005774 File Offset: 0x00003974
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x2E5CA10", Offset = "0x2E5B010", VA = "0x182E5CA10", Slot = "125")]
		private bool AllowsLiftingBeam()
		{
			return default(bool);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0000578C File Offset: 0x0000398C
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x2E5CA30", Offset = "0x2E5B030", VA = "0x182E5CA30", Slot = "117")]
		private Vector3 GetBeamSnapPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000057A4 File Offset: 0x000039A4
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x2E5CDF0", Offset = "0x2E5B3F0", VA = "0x182E5CDF0", Slot = "118")]
		private bool TryGetBeamSnapPoint(Vector3 fromPoint, Vector3 nearPoint, out Vector3 snapPos, out Directions targetDir, out IBeamSupport targetSupport, out int supportQuality)
		{
			return default(bool);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x2E5D8C0", Offset = "0x2E5BEC0", VA = "0x182E5D8C0", Slot = "119")]
		private void LinkSupportedBeamsTogether(ref Directions supportDir, ref BeamDirections beamDir, BeamStructure newBeam)
		{
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x2E5DA70", Offset = "0x2E5C070", VA = "0x182E5DA70", Slot = "170")]
		private void SetAboveTileEdge(Directions dir, ITileEdge tileEdge)
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000057BC File Offset: 0x000039BC
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x2E5DA90", Offset = "0x2E5C090", VA = "0x182E5DA90", Slot = "148")]
		private bool CanHostNewBridgeRope(Directions snapDir)
		{
			return default(bool);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x2E5DB10", Offset = "0x2E5C110", VA = "0x182E5DB10", Slot = "149")]
		private void SetBridgeRope(Directions dir, BridgeRopeStructure bridgeRope)
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000057D4 File Offset: 0x000039D4
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x2E5DB90", Offset = "0x2E5C190", VA = "0x182E5DB90", Slot = "150")]
		private bool TryGetBridgeRope(Directions dir, out BridgeRopeStructure bridgeRope)
		{
			return default(bool);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000057EC File Offset: 0x000039EC
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x2E5DC40", Offset = "0x2E5C240", VA = "0x182E5DC40", Slot = "151")]
		private Vector3 GetBridgeRopeSnapPos()
		{
			return default(Vector3);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00005804 File Offset: 0x00003A04
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x2E5DE20", Offset = "0x2E5C420", VA = "0x182E5DE20", Slot = "152")]
		private Vector3 GetBridgeRopeSecondSnapPos(IBridgeRopeSupport otherSupport)
		{
			return default(Vector3);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0000581C File Offset: 0x00003A1C
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x2E5E0E0", Offset = "0x2E5C6E0", VA = "0x182E5E0E0", Slot = "153")]
		private bool CanHostNewClimbRope(Directions snapDir)
		{
			return default(bool);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x2E5E160", Offset = "0x2E5C760", VA = "0x182E5E160", Slot = "154")]
		private void SetClimbRope(Directions dir, PresetStructure bridgeRope)
		{
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00005834 File Offset: 0x00003A34
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x2E5E1E0", Offset = "0x2E5C7E0", VA = "0x182E5E1E0", Slot = "155")]
		private bool TryGetClimbRope(Directions dir, out PresetStructure bridgeRope)
		{
			return default(bool);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0000584C File Offset: 0x00003A4C
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x2E5E290", Offset = "0x2E5C890", VA = "0x182E5E290", Slot = "156")]
		private Vector3 GetClimbRopeSnapPos(Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00005864 File Offset: 0x00003A64
		[Token(Token = "0x17000268")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x0000587C File Offset: 0x00003A7C
		[Token(Token = "0x17000269")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0xE51960", Offset = "0xE4FF60", VA = "0x180E51960", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700026A")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x2E5E520", Offset = "0x2E5CB20", VA = "0x182E5E520", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700026B")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x2E5E530", Offset = "0x2E5CB30", VA = "0x182E5E530", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700026C")]
		public override Directions[] SupportedByWithRepairPriority
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x2E5E580", Offset = "0x2E5CB80", VA = "0x182E5E580", Slot = "54")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700026D")]
		public static Counter Counter
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x2E5E5D0", Offset = "0x2E5CBD0", VA = "0x182E5E5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x2E5E620", Offset = "0x2E5CC20", VA = "0x182E5E620", Slot = "88")]
		public override string GetDirName(int dir)
		{
			return null;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x2E5E670", Offset = "0x2E5CC70", VA = "0x182E5E670")]
		public void SetStructureAtDir(BeamDirections direction, IStructure structure)
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00005894 File Offset: 0x00003A94
		[Token(Token = "0x600089A")]
		public bool TryGetStructureAtDir<T>(BeamDirections direction, out T structure) where T : class, IStructure
		{
			return default(bool);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600089B")]
		public T GetStructureAtDir<T>(BeamDirections direction) where T : class, IStructure
		{
			return null;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000058AC File Offset: 0x00003AAC
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x2E5E690", Offset = "0x2E5CC90", VA = "0x182E5E690")]
		public bool HasStructureAtDir(BeamDirections direction)
		{
			return default(bool);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x000058C4 File Offset: 0x00003AC4
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x2E5E6F0", Offset = "0x2E5CCF0", VA = "0x182E5E6F0")]
		public bool HasStructureAtDir(BeamDirections direction, IStructure exceptStructure)
		{
			return default(bool);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000058DC File Offset: 0x00003ADC
		[Token(Token = "0x600089E")]
		public bool HasStructureAtDir<T>(BeamDirections direction, [Optional] IStructure exceptStructure) where T : class, IStructure
		{
			return default(bool);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x2E5E770", Offset = "0x2E5CD70", VA = "0x182E5E770")]
		public void CheckIfRequiresInversion(bool preserveElementPos)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000058F4 File Offset: 0x00003AF4
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x2E5EAA0", Offset = "0x2E5D0A0", VA = "0x182E5EAA0", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x2E60270", Offset = "0x2E5E870", VA = "0x182E60270")]
		private Directions[] GetSupportingDirs()
		{
			return null;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0000590C File Offset: 0x00003B0C
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x2E604D0", Offset = "0x2E5EAD0", VA = "0x182E604D0", Slot = "99")]
		public override bool TryGetFallbackSupport(Directions dir, out IStructure fallbackStructure)
		{
			return default(bool);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x2E60AF0", Offset = "0x2E5F0F0", VA = "0x182E60AF0")]
		public void SwitchToFallbackSupport(IBeamSupport leavingSupport, Directions supportBeamDir)
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00005924 File Offset: 0x00003B24
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x2E60C30", Offset = "0x2E5F230", VA = "0x182E60C30")]
		public bool IsGrounded()
		{
			return default(bool);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0000593C File Offset: 0x00003B3C
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x2E60CE0", Offset = "0x2E5F2E0", VA = "0x182E60CE0", Slot = "102")]
		public override float GetStructuralResistanceFactor(int maxDepth)
		{
			return 0f;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00005954 File Offset: 0x00003B54
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x2E610F0", Offset = "0x2E5F6F0", VA = "0x182E610F0", Slot = "101")]
		public override bool IsMissingSupport()
		{
			return default(bool);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0000596C File Offset: 0x00003B6C
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x2E61340", Offset = "0x2E5F940", VA = "0x182E61340", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x2E61400", Offset = "0x2E5FA00", VA = "0x182E61400", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x2E618A0", Offset = "0x2E5FEA0", VA = "0x182E618A0", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00005984 File Offset: 0x00003B84
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x2E62420", Offset = "0x2E60A20", VA = "0x182E62420", Slot = "84")]
		public override float CalcTopHeight()
		{
			return 0f;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2E62500", Offset = "0x2E60B00", VA = "0x182E62500", Slot = "61")]
		public override void OnDestroyingStructure()
		{
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0000599C File Offset: 0x00003B9C
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x2E62850", Offset = "0x2E60E50", VA = "0x182E62850", Slot = "100")]
		public override bool IsSupportingStructure([Optional] IStructure exceptStructure, bool allowFallback = true)
		{
			return default(bool);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x000059B4 File Offset: 0x00003BB4
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x2E62A50", Offset = "0x2E61050", VA = "0x182E62A50")]
		private bool TryLookupLeaningElementPosition(StructureElement elementPrefab, out Vector3 elementPos, out Quaternion rotation, out float lengthScale)
		{
			return default(bool);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x2E63380", Offset = "0x2E61980", VA = "0x182E63380")]
		protected void CalcSupportedBeamElementPosition(StructureElement beamPrefab, out Vector3 elementPos, out Quaternion elementRot, out float lengthScale)
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x2E63B80", Offset = "0x2E62180", VA = "0x182E63B80", Slot = "60")]
		protected override void OnDisassemblingStructure()
		{
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x2E63BB0", Offset = "0x2E621B0", VA = "0x182E63BB0", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x2E63BB0", Offset = "0x2E621B0", VA = "0x182E63BB0", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000059CC File Offset: 0x00003BCC
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x2E63BE0", Offset = "0x2E621E0", VA = "0x182E63BE0")]
		private bool ShouldBlockNav()
		{
			return default(bool);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x2E63BB0", Offset = "0x2E621B0", VA = "0x182E63BB0")]
		private void RefreshNavCut()
		{
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x2E63E60", Offset = "0x2E62460", VA = "0x182E63E60", Slot = "171")]
		private void GetBottomExtremities(out Vector3 backPos, out Vector3 forwardPos)
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x2E64170", Offset = "0x2E62770", VA = "0x182E64170", Slot = "172")]
		private void GetTopExtremities(out Vector3 backPos, out Vector3 forwardPos)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000059E4 File Offset: 0x00003BE4
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x2E641D0", Offset = "0x2E627D0", VA = "0x182E641D0")]
		private Vector3 CalcForwardPos()
		{
			return default(Vector3);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x000059FC File Offset: 0x00003BFC
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x2E64470", Offset = "0x2E62A70", VA = "0x182E64470", Slot = "162")]
		private bool CanHostNewElectricWire()
		{
			return default(bool);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x2E644F0", Offset = "0x2E62AF0", VA = "0x182E644F0", Slot = "163")]
		private void GetPlaceInfo(out Vector3 pos, out Vector3 axis)
		{
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00005A14 File Offset: 0x00003C14
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x2370A50", Offset = "0x236F050", VA = "0x182370A50", Slot = "164")]
		private Directions GetElectricWireDir()
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x2E64660", Offset = "0x2E62C60", VA = "0x182E64660", Slot = "168")]
		private void SetElectricWire(ElectricWireStructure electricWire)
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00005A2C File Offset: 0x00003C2C
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x2E64680", Offset = "0x2E62C80", VA = "0x182E64680", Slot = "169")]
		private bool TryGetElectricWire(out ElectricWireStructure electricWire)
		{
			return default(bool);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x2E64700", Offset = "0x2E62D00", VA = "0x182E64700", Slot = "165")]
		private Directions[] GetElectricWireSupportSiblingsDir()
		{
			return null;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "166")]
		private void GetElectricWireSupportAncestrySiblingsDir(IElectricWireSupport fromSupport, List<ElectricWireStructure> wireList)
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x2E64750", Offset = "0x2E62D50", VA = "0x182E64750", Slot = "167")]
		private Directions[] GetPowerSourceSupportSiblingsDir()
		{
			return null;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00005A44 File Offset: 0x00003C44
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x2E647A0", Offset = "0x2E62DA0", VA = "0x182E647A0")]
		private static BeamDirections GetFloorDir(Directions direction)
		{
			return BeamDirections.BackSupport;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00005A5C File Offset: 0x00003C5C
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "111")]
		private bool CanHostNewFloor()
		{
			return default(bool);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00005A74 File Offset: 0x00003C74
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x2E647B0", Offset = "0x2E62DB0", VA = "0x182E647B0", Slot = "105")]
		private bool AreSiblingStructuresSupportingFloorsAtDir(Directions targetDir)
		{
			return default(bool);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00005A8C File Offset: 0x00003C8C
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x2E64BC0", Offset = "0x2E631C0", VA = "0x182E64BC0", Slot = "106")]
		private bool HasLinkedPerpendicularFloorSupports(Directions targetDir)
		{
			return default(bool);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x2E64C40", Offset = "0x2E63240", VA = "0x182E64C40", Slot = "107")]
		private void GetNearbyFloors(List<FloorStructure> list, int siblingDistance)
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x2E64DC0", Offset = "0x2E633C0", VA = "0x182E64DC0", Slot = "108")]
		private void SetFloorAtDir(Directions direction, FloorStructure floor)
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x2E64E40", Offset = "0x2E63440", VA = "0x182E64E40")]
		public void SetPresetTarpAtDir(Directions direction, PresetTarpStructure presetTarp)
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x2E64EC0", Offset = "0x2E634C0", VA = "0x182E64EC0", Slot = "110")]
		private bool HasFloorAtDir(Directions direction)
		{
			return default(bool);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00005ABC File Offset: 0x00003CBC
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x2E64F60", Offset = "0x2E63560", VA = "0x182E64F60", Slot = "109")]
		private bool TryGetFloorAtDir(Directions direction, out FloorStructure floor)
		{
			return default(bool);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x2E65010", Offset = "0x2E63610", VA = "0x182E65010", Slot = "126")]
		private bool CanHostNewPilar(bool advancedBuildMode)
		{
			return default(bool);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00005AEC File Offset: 0x00003CEC
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x2E651F0", Offset = "0x2E637F0", VA = "0x182E651F0", Slot = "127")]
		private bool HasPilarAtDir(Directions dir)
		{
			return default(bool);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x2E5DA70", Offset = "0x2E5C070", VA = "0x182E5DA70", Slot = "128")]
		private void SetPilarAtDir(Directions dir, PilarStructure pilar)
		{
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00005B04 File Offset: 0x00003D04
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x2E65250", Offset = "0x2E63850", VA = "0x182E65250", Slot = "129")]
		private bool TryGetPilarAtDir(Directions dir, out PilarStructure pilar)
		{
			return default(bool);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00005B1C File Offset: 0x00003D1C
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x2E652E0", Offset = "0x2E638E0", VA = "0x182E652E0", Slot = "130")]
		private Vector3 GetPilarSnapPos(Vector3 nearPos)
		{
			return default(Vector3);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00005B34 File Offset: 0x00003D34
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x2E65350", Offset = "0x2E63950", VA = "0x182E65350", Slot = "131")]
		private Vector3 GetPilarSnapPos(Directions targetDir)
		{
			return default(Vector3);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00005B4C File Offset: 0x00003D4C
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x2E65450", Offset = "0x2E63A50", VA = "0x182E65450", Slot = "132")]
		private bool TryGetPilarDir(PilarStructure pilar, out Directions pilarDir)
		{
			return default(bool);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00005B64 File Offset: 0x00003D64
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x2E656F0", Offset = "0x2E63CF0", VA = "0x182E656F0", Slot = "134")]
		private bool IsBackDir(int dir)
		{
			return default(bool);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00005B7C File Offset: 0x00003D7C
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x2E65710", Offset = "0x2E63D10", VA = "0x182E65710", Slot = "136")]
		private bool AreSiblingSupportingCrossedWalls(Directions targetDir, bool advancedBuildMode)
		{
			return default(bool);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x2E65940", Offset = "0x2E63F40", VA = "0x182E65940", Slot = "133")]
		private Directions[] GetAbovePilarDirs()
		{
			return null;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x2E65990", Offset = "0x2E63F90", VA = "0x182E65990", Slot = "135")]
		private void GetSiblingSupportDirs(bool atBack, out Directions dirFrom, out Directions dirTo)
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x2E659C0", Offset = "0x2E63FC0", VA = "0x182E659C0", Slot = "112")]
		private void SetRampAtDir(Directions direction, RampStructure floor)
		{
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00005B94 File Offset: 0x00003D94
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x2E65A40", Offset = "0x2E64040", VA = "0x182E65A40", Slot = "113")]
		private bool HasRampAtDir(Directions direction)
		{
			return default(bool);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00005BAC File Offset: 0x00003DAC
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x2E65AE0", Offset = "0x2E640E0", VA = "0x182E65AE0", Slot = "115")]
		private bool CanHostNewRamp()
		{
			return default(bool);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x2E65B60", Offset = "0x2E64160", VA = "0x182E65B60", Slot = "114")]
		private bool TryGetRampAtDir(Directions direction, out RampStructure floor)
		{
			return default(bool);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x2E65C10", Offset = "0x2E64210", VA = "0x182E65C10", Slot = "116")]
		private Directions[] GetRampDirs()
		{
			return null;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00005BDC File Offset: 0x00003DDC
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x2E65C70", Offset = "0x2E64270", VA = "0x182E65C70", Slot = "157")]
		private bool CanHostSingleStep()
		{
			return default(bool);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x2E65CE0", Offset = "0x2E642E0", VA = "0x182E65CE0", Slot = "158")]
		private void SetSingleStep(Directions dir, SingleStepStructure singleStep)
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00005BF4 File Offset: 0x00003DF4
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x2E65D60", Offset = "0x2E64360", VA = "0x182E65D60", Slot = "159")]
		private bool HasSingleStep(Directions dir)
		{
			return default(bool);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00005C0C File Offset: 0x00003E0C
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x2E65E00", Offset = "0x2E64400", VA = "0x182E65E00", Slot = "160")]
		private Vector3 GetSingleStepPos(Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00005C24 File Offset: 0x00003E24
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x2E66160", Offset = "0x2E64760", VA = "0x182E66160", Slot = "161")]
		private Vector3 CalcRampUpAxis(Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00005C3C File Offset: 0x00003E3C
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00")]
		private BeamDirections GetWallBeamDirection(Directions dir)
		{
			return BeamDirections.BackSupport;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00005C54 File Offset: 0x00003E54
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x2E662E0", Offset = "0x2E648E0", VA = "0x182E662E0", Slot = "141")]
		private bool CanHostNewWall()
		{
			return default(bool);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x2E66450", Offset = "0x2E64A50", VA = "0x182E66450", Slot = "142")]
		private void SetWallAtDir(Directions dir, WallStructure wall)
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00005C6C File Offset: 0x00003E6C
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x2E66470", Offset = "0x2E64A70", VA = "0x182E66470", Slot = "143")]
		private bool HasWallAtDir(Directions dir)
		{
			return default(bool);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00005C84 File Offset: 0x00003E84
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x2E664C0", Offset = "0x2E64AC0", VA = "0x182E664C0", Slot = "144")]
		private bool TryGetWallAtDir(Directions dir, out WallStructure wall)
		{
			return default(bool);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x2E66540", Offset = "0x2E64B40", VA = "0x182E66540", Slot = "145")]
		private Directions[] GetAllWallSnapPointsDirs()
		{
			return null;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00005C9C File Offset: 0x00003E9C
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xE51980", Offset = "0xE4FF80", VA = "0x180E51980", Slot = "146")]
		private Directions GetWallDirForWallPos(Vector3 wallPos)
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00005CB4 File Offset: 0x00003EB4
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x2E665A0", Offset = "0x2E64BA0", VA = "0x182E665A0", Slot = "147")]
		private bool TryGetWallPlacementInfo(Directions targetDir, StructureElement wallPrefab, out Vector3 snapPos, out Vector3 placeAxis)
		{
			return default(bool);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x2E66760", Offset = "0x2E64D60", VA = "0x182E66760")]
		public BeamStructure()
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00005CCC File Offset: 0x00003ECC
		[Token(Token = "0x60008EA")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x2E674A0", Offset = "0x2E65AA0", VA = "0x182E674A0")]
		[CompilerGenerated]
		private void <Construction.IBeamSupport.LinkSupportedBeamsTogether>g__PerformLinking|13_0(BeamDirections beamSupportDir, ref BeamStructure.<>c__DisplayClass13_0 A_2)
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00005CE4 File Offset: 0x00003EE4
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x2E68470", Offset = "0x2E66A70", VA = "0x182E68470")]
		[CompilerGenerated]
		internal static bool <CheckIfRequiresInversion>g__CheckSupportIsValid|55_0(IBeamSupport support)
		{
			return default(bool);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00005CFC File Offset: 0x00003EFC
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x2E68550", Offset = "0x2E66B50", VA = "0x182E68550")]
		[CompilerGenerated]
		private bool <IsSupportingStructure>g__RequiredToSupportBeams|68_0(BeamDirections support, ref BeamStructure.<>c__DisplayClass68_0 A_2)
		{
			return default(bool);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00005D14 File Offset: 0x00003F14
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x2E68CA0", Offset = "0x2E672A0", VA = "0x182E68CA0")]
		[CompilerGenerated]
		private bool <IsSupportingStructure>g__AboveDirIsFreeOrTransferable|68_1(Directions directions, IStructure except, ref BeamStructure.<>c__DisplayClass68_0 A_3)
		{
			return default(bool);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x2E68E50", Offset = "0x2E67450", VA = "0x182E68E50")]
		[CompilerGenerated]
		private void <TryLookupLeaningElementPosition>g__SetupFakePilar|69_0(Vector3 fpPos)
		{
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x2E69300", Offset = "0x2E67900", VA = "0x182E69300")]
		[CompilerGenerated]
		private void <OnDisassemblingStructure>g__TryTransferAboveStructures|71_0(Directions directions)
		{
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x2E69870", Offset = "0x2E67E70", VA = "0x182E69870")]
		[CompilerGenerated]
		private void <Construction.IFloorSupport.GetNearbyFloors>g__GetFloorAtDir|93_0(Directions dir, ref BeamStructure.<>c__DisplayClass93_0 A_2)
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x2E699E0", Offset = "0x2E67FE0", VA = "0x182E699E0")]
		[CompilerGenerated]
		private void <Construction.IFloorSupport.GetNearbyFloors>g__GetSiblingFloorAtDir|93_1(BeamDirections dir, ref BeamStructure.<>c__DisplayClass93_0 A_2)
		{
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00005D2C File Offset: 0x00003F2C
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x2E69B10", Offset = "0x2E68110", VA = "0x182E69B10")]
		[CompilerGenerated]
		private bool <Construction.IPilarSupport.CanHostNewPilar>g__FollowsSimpleBuildModeRules|98_0()
		{
			return default(bool);
		}

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Directions[] StruttedSupportsBeamDirs;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Directions[] WallSupportsBeamDirs;

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Directions[] NonStruttedSupportsBeamDirs;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly Directions[] WithBackSupportSupportingDirs;

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly Directions[] WithForwardSupportSupportingDirs;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly Directions[] WithBackAndForwardSupportSupportingDirs;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly Directions[] SupportedByDirsWithRepairPriority;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly BeamDirections[] BackSiblingDirs;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly BeamDirections[] ForwardSiblingDirs;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly Directions[] ElectricWireSupportSiblingsDirs;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly Directions[] PowerSourceSupportSiblingsDirs;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly Directions[] AbovePilarDirs;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly BeamDirections[] BackSiblings;

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly BeamDirections[] ForwardSiblings;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly BeamDirections[] AllSiblings;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static readonly Directions[] RampDirs;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static readonly Directions[] WallSnapPointsDirs;

		// Token: 0x02000134 RID: 308
		[Token(Token = "0x2000134")]
		public static class Stitching
		{
			// Token: 0x060008F4 RID: 2292 RVA: 0x00005D44 File Offset: 0x00003F44
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x2E69C60", Offset = "0x2E68260", VA = "0x182E69C60")]
			public static bool LookupForBeamForwardStitching(IBeamSupport support1, TargetInfo stitchingTarget, ref Vector3 beamPos, ref Vector3 beamAxis, [Optional] IBeamSupport except)
			{
				return default(bool);
			}

			// Token: 0x060008F5 RID: 2293 RVA: 0x00005D5C File Offset: 0x00003F5C
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x2E6AA40", Offset = "0x2E69040", VA = "0x182E6AA40")]
			private static bool PreventLeaningThroughPartiallyBuiltWall(IStructure foundSupport, ref BeamStructure.Stitching.StitchingData stitchingData)
			{
				return default(bool);
			}

			// Token: 0x060008F6 RID: 2294 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x2E6AAF0", Offset = "0x2E690F0", VA = "0x182E6AAF0")]
			private static void CheckForTerrainOrWaterHit(TargetInfo stitchingTarget, ref RaycastHit hit, ref Vector3 hitPos, ref BeamStructure.Stitching.StitchingData stitchingData, int index)
			{
			}

			// Token: 0x060008F7 RID: 2295 RVA: 0x00005D74 File Offset: 0x00003F74
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x2E6AF30", Offset = "0x2E69530", VA = "0x182E6AF30")]
			private static bool ValidateSupport(IBeamSupport except, IStructure foundSupport, ref Vector3 hitPos, ref BeamStructure.Stitching.StitchingData stitchingData, out IBeamSupport beamSupport)
			{
				return default(bool);
			}

			// Token: 0x060008F8 RID: 2296 RVA: 0x00005D8C File Offset: 0x00003F8C
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x2E6B030", Offset = "0x2E69630", VA = "0x182E6B030")]
			private static bool CheckForGroundedBeamFakePilar(float leveledHeight, Vector3 hitPoint, out Directions targetDir2, bool waterBorne)
			{
				return default(bool);
			}

			// Token: 0x04000645 RID: 1605
			[Token(Token = "0x4000645")]
			public const Directions UsableFakePilarDirCode = Directions.Under;

			// Token: 0x04000646 RID: 1606
			[Token(Token = "0x4000646")]
			public const Directions DummyFakePilarDirCode = Directions.Forward;

			// Token: 0x04000647 RID: 1607
			[Token(Token = "0x4000647")]
			public const Directions WaterFakePilarDirCode = Directions.Above;

			// Token: 0x02000135 RID: 309
			[Token(Token = "0x2000135")]
			private struct StitchingData
			{
				// Token: 0x060008F9 RID: 2297 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60008F9")]
				[Address(RVA = "0x2E6B080", Offset = "0x2E69680", VA = "0x182E6B080")]
				public StitchingData(IBeamSupport support1, Vector3 beamPos, Vector3 leveledCastPos)
				{
				}

				// Token: 0x060008FA RID: 2298 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60008FA")]
				[Address(RVA = "0x2E6B2D0", Offset = "0x2E698D0", VA = "0x182E6B2D0")]
				public void CheckHeightMadness()
				{
				}

				// Token: 0x060008FB RID: 2299 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60008FB")]
				[Address(RVA = "0x2E6B400", Offset = "0x2E69A00", VA = "0x182E6B400")]
				public void ResetWithMinHeight(float wallHeight)
				{
				}

				// Token: 0x04000648 RID: 1608
				[Token(Token = "0x4000648")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public IBeamSupport support1;

				// Token: 0x04000649 RID: 1609
				[Token(Token = "0x4000649")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float originalBeamSupportTop;

				// Token: 0x0400064A RID: 1610
				[Token(Token = "0x400064A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public Vector3 lookAtPos;

				// Token: 0x0400064B RID: 1611
				[Token(Token = "0x400064B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int bestHitIndex;

				// Token: 0x0400064C RID: 1612
				[Token(Token = "0x400064C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public Vector3 bestSnapPos2;

				// Token: 0x0400064D RID: 1613
				[Token(Token = "0x400064D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public float bestSnapHeightMadness;

				// Token: 0x0400064E RID: 1614
				[Token(Token = "0x400064E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				public Directions bestSupport2Dir;

				// Token: 0x0400064F RID: 1615
				[Token(Token = "0x400064F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public IBeamSupport bestTargetSupport;

				// Token: 0x04000650 RID: 1616
				[Token(Token = "0x4000650")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public bool bestSupportIsWater;

				// Token: 0x04000651 RID: 1617
				[Token(Token = "0x4000651")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
				public int bestSupportQuality;
			}
		}

		// Token: 0x02000136 RID: 310
		[Token(Token = "0x2000136")]
		public static class Utils
		{
			// Token: 0x060008FC RID: 2300 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x2E6B480", Offset = "0x2E69A80", VA = "0x182E6B480")]
			public static IBeamSupport GetBackSupport(BeamStructure beam, bool allowSecondarySupports = false, [Optional] IBeamSupport except)
			{
				return null;
			}

			// Token: 0x060008FD RID: 2301 RVA: 0x00005DA4 File Offset: 0x00003FA4
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x2E6B6C0", Offset = "0x2E69CC0", VA = "0x182E6B6C0")]
			public static bool TryGetBackSupport(BeamStructure beam, out IBeamSupport backSupport, out BeamDirections supportDir, bool allowSecondarySupports = false, [Optional] IBeamSupport except)
			{
				return default(bool);
			}

			// Token: 0x060008FE RID: 2302 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x2E6B890", Offset = "0x2E69E90", VA = "0x182E6B890")]
			public static IBeamSupport GetForwardSupport(BeamStructure beam, bool allowSecondarySupports = false, [Optional] IBeamSupport except)
			{
				return null;
			}

			// Token: 0x060008FF RID: 2303 RVA: 0x00005DBC File Offset: 0x00003FBC
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x2E6BAD0", Offset = "0x2E6A0D0", VA = "0x182E6BAD0")]
			public static bool TryGetForwardSupport(BeamStructure beam, out IBeamSupport forwardSupport, out BeamDirections supportDir, bool allowSecondarySupports = false, [Optional] IBeamSupport except)
			{
				return default(bool);
			}

			// Token: 0x06000900 RID: 2304 RVA: 0x00005DD4 File Offset: 0x00003FD4
			[Token(Token = "0x6000900")]
			[Address(RVA = "0x2E6BCD0", Offset = "0x2E6A2D0", VA = "0x182E6BCD0")]
			public static bool IsSupportedByAnotherBeam(BeamStructure beam)
			{
				return default(bool);
			}

			// Token: 0x06000901 RID: 2305 RVA: 0x00005DEC File Offset: 0x00003FEC
			[Token(Token = "0x6000901")]
			[Address(RVA = "0x2E6C0A0", Offset = "0x2E6A6A0", VA = "0x182E6C0A0")]
			public static bool IsSupportedByAnotherBeamOrStrut(BeamStructure beam)
			{
				return default(bool);
			}

			// Token: 0x06000902 RID: 2306 RVA: 0x00005E04 File Offset: 0x00004004
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x2E6C4A0", Offset = "0x2E6AAA0", VA = "0x182E6C4A0")]
			public static bool IsOnSoloSupport(BeamStructure beam)
			{
				return default(bool);
			}

			// Token: 0x06000903 RID: 2307 RVA: 0x00005E1C File Offset: 0x0000401C
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x2E6C580", Offset = "0x2E6AB80", VA = "0x182E6C580")]
			public static bool CanBeLifted(BeamStructure beam)
			{
				return default(bool);
			}

			// Token: 0x06000904 RID: 2308 RVA: 0x00005E34 File Offset: 0x00004034
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x2E6C750", Offset = "0x2E6AD50", VA = "0x182E6C750")]
			public static bool IsLockedLeaning(BeamStructure beam)
			{
				return default(bool);
			}

			// Token: 0x06000905 RID: 2309 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x2E6C820", Offset = "0x2E6AE20", VA = "0x182E6C820")]
			public static void CalcDroopingLevels(BeamStructure beam, out int backDroopingLevel, out int forwardDroopingLevel)
			{
			}

			// Token: 0x06000906 RID: 2310 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000906")]
			[Address(RVA = "0x2E6CD40", Offset = "0x2E6B340", VA = "0x182E6CD40")]
			internal static void GetBeamDirectionFromBeamSupport(ITileEdge fromBeam, ITileEdge toBeam, out BeamDirections fromBeamDir, out BeamDirections toBeamDir)
			{
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x2E6CDD0", Offset = "0x2E6B3D0", VA = "0x182E6CDD0")]
			public static void LinkBeamWithSupport(BeamStructure beam, BeamDirections beamDir, IBeamSupport support, Directions supportDir)
			{
			}

			// Token: 0x06000908 RID: 2312 RVA: 0x00005E4C File Offset: 0x0000404C
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x2D86CB0", Offset = "0x2D852B0", VA = "0x182D86CB0")]
			public static float CalcStructureToElementDistance(StructureElement beamPrefab)
			{
				return 0f;
			}

			// Token: 0x06000909 RID: 2313 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x2E6CF30", Offset = "0x2E6B530", VA = "0x182E6CF30")]
			internal static void GetBeamDirectionsForTargetPosFromPilar(PilarStructure targetPilar, Vector3 targetPos, out Directions dirA, out Directions dirB)
			{
			}

			// Token: 0x0600090A RID: 2314 RVA: 0x00005E64 File Offset: 0x00004064
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x2E6D090", Offset = "0x2E6B690", VA = "0x182E6D090")]
			internal static Vector3 CalcBeamOnSideOfApexEndExtremity(ApexStructure targetApex, Directions targetDir)
			{
				return default(Vector3);
			}

			// Token: 0x0600090B RID: 2315 RVA: 0x00005E7C File Offset: 0x0000407C
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x2E6D2B0", Offset = "0x2E6B8B0", VA = "0x182E6D2B0")]
			public static WallDirections GetBeamOnWallDirFromWall(Vector3 lookAtPos, WallStructure wall)
			{
				return (WallDirections)0;
			}

			// Token: 0x0600090C RID: 2316 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x2E6D400", Offset = "0x2E6BA00", VA = "0x182E6D400")]
			public static void GetBeamOnBeamForwardSnapPoint(BeamStructure supportingBeam, Vector3 fromTargetPos, out Vector3 snapPos)
			{
			}

			// Token: 0x0600090D RID: 2317 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x2E6D610", Offset = "0x2E6BC10", VA = "0x182E6D610")]
			public static void CastBeamBackToLeaningState(BeamStructure beam)
			{
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x2E6DB60", Offset = "0x2E6C160", VA = "0x182E6DB60")]
			public static FakePilarStructure GenerateFakePilar(StructureElement fakePilarPrefab, BeamStructure beamStructure, Vector3 pilarPos, Directions pilarBeamDir, BeamDirections beamPilarDir, bool addElement = true, bool placingUpHill = false)
			{
				return null;
			}

			// Token: 0x0600090F RID: 2319 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x2E6DF70", Offset = "0x2E6C570", VA = "0x182E6DF70")]
			public static void InvertBeamOrientation(BeamStructure beam, bool preserveElementPos = false)
			{
			}

			// Token: 0x06000910 RID: 2320 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x2E6E370", Offset = "0x2E6C970", VA = "0x182E6E370")]
			public static void InvertBeamOrientation(BeamStructure beam, Vector3 forwardPos)
			{
			}

			// Token: 0x06000911 RID: 2321 RVA: 0x00005E94 File Offset: 0x00004094
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x2E6E600", Offset = "0x2E6CC00", VA = "0x182E6E600")]
			public static bool IsRequiredForSupportedBeams(IBeamSupport beamSupport)
			{
				return default(bool);
			}

			// Token: 0x06000912 RID: 2322 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x2E6EA00", Offset = "0x2E6D000", VA = "0x182E6EA00")]
			public static void LinkBeamWithNearbyBeams(BeamStructure beam)
			{
			}

			// Token: 0x06000913 RID: 2323 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x2E6EA60", Offset = "0x2E6D060", VA = "0x182E6EA60")]
			public static void LinkBeamWithNearbyPilars(BeamStructure beam)
			{
			}

			// Token: 0x06000914 RID: 2324 RVA: 0x00005EAC File Offset: 0x000040AC
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x2E6ECF0", Offset = "0x2E6D2F0", VA = "0x182E6ECF0")]
			public static bool HasSiblingStruttedBeam(BeamStructure beam, bool atBack, bool atBackOfStrutOnly)
			{
				return default(bool);
			}

			// Token: 0x06000915 RID: 2325 RVA: 0x00005EC4 File Offset: 0x000040C4
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x2E6EE90", Offset = "0x2E6D490", VA = "0x182E6EE90")]
			public static bool HasSupportingStruttedBeam(BeamStructure beam, bool atBack)
			{
				return default(bool);
			}

			// Token: 0x06000916 RID: 2326 RVA: 0x00005EDC File Offset: 0x000040DC
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x2E6F200", Offset = "0x2E6D800", VA = "0x182E6F200")]
			public static bool ShouldBeAboveBeam(BeamStructure beam, BeamStructure sibling)
			{
				return default(bool);
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x2E6F3D0", Offset = "0x2E6D9D0", VA = "0x182E6F3D0")]
			public static void SpawnInvalidPlacementPickup(TargetInfo targetInfo, ModuleProfile profile)
			{
			}

			// Token: 0x06000918 RID: 2328 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x2E6F910", Offset = "0x2E6DF10", VA = "0x182E6F910")]
			public static void CreateFakeBeam(IBeamSupport backSupport, IBeamSupport forwardSupport)
			{
			}

			// Token: 0x06000919 RID: 2329 RVA: 0x00005EF4 File Offset: 0x000040F4
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x2E70220", Offset = "0x2E6E820", VA = "0x182E70220")]
			public static bool CheckForwardFakePilarCreation(TargetInfo targetInfo, ModuleProfileDatabase groundedFakePilarDb, ModuleProfileDatabase waterBorneFakePilarDb, ModuleProfile beamProfile, BeamStructure editingBeamStructure)
			{
				return default(bool);
			}

			// Token: 0x0600091A RID: 2330 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x2E707B0", Offset = "0x2E6EDB0", VA = "0x182E707B0")]
			public static void CheckFakePilarCompletion(ModuleProfileDatabase groundedFakePilarProfileDatabase, IStructure support, bool refreshBeam = true)
			{
			}

			// Token: 0x0600091B RID: 2331 RVA: 0x00005F0C File Offset: 0x0000410C
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x2E70D20", Offset = "0x2E6F320", VA = "0x182E70D20")]
			public static bool TryGetAboveLeaningBeam(BeamStructure supportingBeam, BeamDirections beamDir, out BeamStructure aboveLeaningBeam)
			{
				return default(bool);
			}

			// Token: 0x0600091C RID: 2332 RVA: 0x00005F24 File Offset: 0x00004124
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x2E710F0", Offset = "0x2E6F6F0", VA = "0x182E710F0")]
			private static bool AreElementAbove(BeamStructure beamA, BeamStructure beamB)
			{
				return default(bool);
			}

			// Token: 0x0600091E RID: 2334 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x2E71470", Offset = "0x2E6FA70", VA = "0x182E71470")]
			[CompilerGenerated]
			internal static BeamStructure <CalcDroopingLevels>g__FindNextSupportingBeamAtDirection|9_0(BeamStructure beamStructure, BeamStructure nextBeam, Directions searchingDir)
			{
				return null;
			}

			// Token: 0x0600091F RID: 2335 RVA: 0x00005F3C File Offset: 0x0000413C
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x2E716C0", Offset = "0x2E6FCC0", VA = "0x182E716C0")]
			[CompilerGenerated]
			internal static bool <CalcDroopingLevels>g__HasPerpendicularStruttedBeam|9_1(BeamStructure beamStructure, Directions searchingDir)
			{
				return default(bool);
			}

			// Token: 0x06000920 RID: 2336 RVA: 0x00005F54 File Offset: 0x00004154
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x2E71880", Offset = "0x2E6FE80", VA = "0x182E71880")]
			[CompilerGenerated]
			internal static BeamDirections <GetBeamDirectionFromBeamSupport>g__CalcBeamDir|10_0(ITileEdge fromBeam, ITileEdge toBeam)
			{
				return BeamDirections.BackSupport;
			}

			// Token: 0x06000921 RID: 2337 RVA: 0x00005F6C File Offset: 0x0000416C
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x2E71EA0", Offset = "0x2E704A0", VA = "0x182E71EA0")]
			[CompilerGenerated]
			internal static bool <IsRequiredForSupportedBeams>g__IsBeamOnSlope|21_0(BeamStructure beam)
			{
				return default(bool);
			}

			// Token: 0x06000922 RID: 2338 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x2E71FB0", Offset = "0x2E705B0", VA = "0x182E71FB0")]
			[CompilerGenerated]
			internal static List<BeamStructure> <LinkBeamWithNearbyBeams>g__GetNearbyBeamsList|22_0(BeamStructure newBeam)
			{
				return null;
			}

			// Token: 0x06000923 RID: 2339 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x2E722F0", Offset = "0x2E708F0", VA = "0x182E722F0")]
			[CompilerGenerated]
			internal static void <LinkBeamWithNearbyBeams>g__LinkBeamToNearbyBeams|22_1(List<BeamStructure> nearbyBeamList, BeamStructure newBeam)
			{
			}

			// Token: 0x06000924 RID: 2340 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x2E72520", Offset = "0x2E70B20", VA = "0x182E72520")]
			[CompilerGenerated]
			internal static void <LinkBeamWithNearbyPilars>g__LinkBeamToNearbyBeams|23_0(List<PilarStructure> nearbyPilarList, BeamStructure newBeam, BeamDirections beamDir, Vector3 onBeamPos)
			{
			}

			// Token: 0x06000925 RID: 2341 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x2E72920", Offset = "0x2E70F20", VA = "0x182E72920")]
			[CompilerGenerated]
			internal static void <CheckFakePilarCompletion>g__PositionFakePilar|32_0(FakePilarStructure fakePilar, float height)
			{
			}

			// Token: 0x06000926 RID: 2342 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x2E72B40", Offset = "0x2E71140", VA = "0x182E72B40")]
			[CompilerGenerated]
			internal static void <CheckFakePilarCompletion>g__CompleteFakePilar|32_1(FakePilarStructure fakePilar, ModuleProfileDatabase pilarProfileDB, ItemData item)
			{
			}

			// Token: 0x04000652 RID: 1618
			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Directions[] OppositeDirs;

			// Token: 0x04000653 RID: 1619
			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly BeamDirections[] OppositeBeamDirs;
		}
	}
}
