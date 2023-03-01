using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000151 RID: 337
[Token(Token = "0x2000151")]
public class playerScriptSetup : MonoBehaviour
{
	// Token: 0x17000141 RID: 321
	// (get) Token: 0x060009FE RID: 2558 RVA: 0x00004830 File Offset: 0x00002A30
	// (set) Token: 0x060009FF RID: 2559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000141")]
	public bool HitDetection
	{
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x5A48B0", Offset = "0x5A38B0", VA = "0x1805A48B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x5A50E0", Offset = "0x5A40E0", VA = "0x1805A50E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x2F5B6D0", Offset = "0x2F5A6D0", VA = "0x182F5B6D0")]
	private void Awake()
	{
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x2F5C2C0", Offset = "0x2F5B2C0", VA = "0x182F5C2C0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x2F5B870", Offset = "0x2F5A870", VA = "0x182F5B870")]
	private void FindLinkedChildren()
	{
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A03")]
	[Address(RVA = "0x2F5C370", Offset = "0x2F5B370", VA = "0x182F5C370")]
	private void Start()
	{
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A04")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void unParentPlayerBase()
	{
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x2F5C470", Offset = "0x2F5B470", VA = "0x182F5C470")]
	private void checkPlaneCrash()
	{
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x2F5C060", Offset = "0x2F5B060", VA = "0x182F5C060")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x2F5C1D0", Offset = "0x2F5B1D0", VA = "0x182F5C1D0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x2F5C2D0", Offset = "0x2F5B2D0", VA = "0x182F5C2D0")]
	public void SetHitDetection(bool value)
	{
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x2F5C460", Offset = "0x2F5B460", VA = "0x182F5C460")]
	public playerScriptSetup()
	{
	}

	// Token: 0x04000871 RID: 2161
	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0x20")]
	public SimpleMouseRotator mainRotator;

	// Token: 0x04000872 RID: 2162
	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x28")]
	public PlayerStats stats;

	// Token: 0x04000873 RID: 2163
	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0x30")]
	public targetStats targetInfo;

	// Token: 0x04000874 RID: 2164
	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x38")]
	public animEventsManager events;

	// Token: 0x04000875 RID: 2165
	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0x40")]
	public ForceLocalPosZero forceLocalPos;

	// Token: 0x04000876 RID: 2166
	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0x48")]
	public treeHitTrigger treeHit;

	// Token: 0x04000877 RID: 2167
	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x50")]
	public Transform AxeAimGuide;

	// Token: 0x04000878 RID: 2168
	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x58")]
	public Transform logSlidePivot;

	// Token: 0x04000879 RID: 2169
	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x60")]
	public Transform digTileAign;

	// Token: 0x0400087A RID: 2170
	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0x68")]
	public Transform weaponRight;

	// Token: 0x0400087B RID: 2171
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x70")]
	public Transform constrainTr;

	// Token: 0x0400087C RID: 2172
	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x78")]
	public Transform lookAtTr;

	// Token: 0x0400087D RID: 2173
	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x80")]
	public Transform spine1;

	// Token: 0x0400087E RID: 2174
	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x88")]
	public Transform spine2;

	// Token: 0x0400087F RID: 2175
	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x90")]
	public Transform spine3;

	// Token: 0x04000880 RID: 2176
	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x98")]
	public Transform playerCam;

	// Token: 0x04000881 RID: 2177
	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0xA0")]
	public Transform OvrCam;

	// Token: 0x04000882 RID: 2178
	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0xA8")]
	public Transform camParent;

	// Token: 0x04000883 RID: 2179
	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0xB0")]
	public Transform hipsJnt;

	// Token: 0x04000884 RID: 2180
	[Token(Token = "0x4000884")]
	[FieldOffset(Offset = "0xB8")]
	public Transform head0Jnt;

	// Token: 0x04000885 RID: 2181
	[Token(Token = "0x4000885")]
	[FieldOffset(Offset = "0xC0")]
	public Transform headJnt;

	// Token: 0x04000886 RID: 2182
	[Token(Token = "0x4000886")]
	[FieldOffset(Offset = "0xC8")]
	public Transform neckJnt;

	// Token: 0x04000887 RID: 2183
	[Token(Token = "0x4000887")]
	[FieldOffset(Offset = "0xD0")]
	public Transform neck1Jnt;

	// Token: 0x04000888 RID: 2184
	[Token(Token = "0x4000888")]
	[FieldOffset(Offset = "0xD8")]
	public Transform leftHand;

	// Token: 0x04000889 RID: 2185
	[Token(Token = "0x4000889")]
	[FieldOffset(Offset = "0xE0")]
	public Transform leftHandHeld;

	// Token: 0x0400088A RID: 2186
	[Token(Token = "0x400088A")]
	[FieldOffset(Offset = "0xE8")]
	public Transform rightHandHeld;

	// Token: 0x0400088B RID: 2187
	[Token(Token = "0x400088B")]
	[FieldOffset(Offset = "0xF0")]
	public Transform leftHandWrist;

	// Token: 0x0400088C RID: 2188
	[Token(Token = "0x400088C")]
	[FieldOffset(Offset = "0xF8")]
	public Transform leftArm;

	// Token: 0x0400088D RID: 2189
	[Token(Token = "0x400088D")]
	[FieldOffset(Offset = "0x100")]
	public Transform rightArm;

	// Token: 0x0400088E RID: 2190
	[Token(Token = "0x400088E")]
	[FieldOffset(Offset = "0x108")]
	public Transform rightHandWrist;

	// Token: 0x0400088F RID: 2191
	[Token(Token = "0x400088F")]
	[FieldOffset(Offset = "0x110")]
	public Transform leftElbowIkTargetLow;

	// Token: 0x04000890 RID: 2192
	[Token(Token = "0x4000890")]
	[FieldOffset(Offset = "0x118")]
	public GameObject weaponCube;

	// Token: 0x04000891 RID: 2193
	[Token(Token = "0x4000891")]
	[FieldOffset(Offset = "0x120")]
	public GameObject playerBase;

	// Token: 0x04000892 RID: 2194
	[Token(Token = "0x4000892")]
	[FieldOffset(Offset = "0x128")]
	public GameObject heldLog1;

	// Token: 0x04000893 RID: 2195
	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x130")]
	public GameObject heldLog2;

	// Token: 0x04000894 RID: 2196
	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x138")]
	public GameObject heldBow;

	// Token: 0x04000895 RID: 2197
	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0x140")]
	public GameObject heldBowTip;

	// Token: 0x04000896 RID: 2198
	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x148")]
	public GameObject heldModernBow;

	// Token: 0x04000897 RID: 2199
	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0x150")]
	public GameObject heldModernBowTip;

	// Token: 0x04000898 RID: 2200
	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[FormerlySerializedAs("bodyCollisionGo")]
	[FormerlySerializedAs("_hitDetectionGo")]
	private GameObject _damageControllerGo;
}
