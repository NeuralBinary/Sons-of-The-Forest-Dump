using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000150 RID: 336
[Token(Token = "0x2000150")]
public class playerScriptSetup : MonoBehaviour
{
	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00004A40 File Offset: 0x00002C40
	// (set) Token: 0x06000A4F RID: 2639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700014A")]
	public bool HitDetection
	{
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x623AB0", Offset = "0x6220B0", VA = "0x180623AB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x623AC0", Offset = "0x6220C0", VA = "0x180623AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A50")]
	[Address(RVA = "0x36B2410", Offset = "0x36B0A10", VA = "0x1836B2410")]
	private void Awake()
	{
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A51")]
	[Address(RVA = "0x36B2940", Offset = "0x36B0F40", VA = "0x1836B2940")]
	private void OnValidate()
	{
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x36B2950", Offset = "0x36B0F50", VA = "0x1836B2950")]
	private void FindLinkedChildren()
	{
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x36B3710", Offset = "0x36B1D10", VA = "0x1836B3710")]
	private void Start()
	{
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void unParentPlayerBase()
	{
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x36B38D0", Offset = "0x36B1ED0", VA = "0x1836B38D0")]
	private void checkPlaneCrash()
	{
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A56")]
	[Address(RVA = "0x36B3BD0", Offset = "0x36B21D0", VA = "0x1836B3BD0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x36B3F10", Offset = "0x36B2510", VA = "0x1836B3F10")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A58")]
	[Address(RVA = "0x36B41A0", Offset = "0x36B27A0", VA = "0x1836B41A0")]
	public void SetHitDetection(bool value)
	{
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x36B42D0", Offset = "0x36B28D0", VA = "0x1836B42D0")]
	public playerScriptSetup()
	{
	}

	// Token: 0x04000892 RID: 2194
	[Token(Token = "0x4000892")]
	[FieldOffset(Offset = "0x20")]
	public SimpleMouseRotator mainRotator;

	// Token: 0x04000893 RID: 2195
	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x28")]
	public PlayerStats stats;

	// Token: 0x04000894 RID: 2196
	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x30")]
	public targetStats targetInfo;

	// Token: 0x04000895 RID: 2197
	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0x38")]
	public animEventsManager events;

	// Token: 0x04000896 RID: 2198
	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x40")]
	public ForceLocalPosZero forceLocalPos;

	// Token: 0x04000897 RID: 2199
	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0x48")]
	public treeHitTrigger treeHit;

	// Token: 0x04000898 RID: 2200
	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0x50")]
	public Transform AxeAimGuide;

	// Token: 0x04000899 RID: 2201
	[Token(Token = "0x4000899")]
	[FieldOffset(Offset = "0x58")]
	public Transform logSlidePivot;

	// Token: 0x0400089A RID: 2202
	[Token(Token = "0x400089A")]
	[FieldOffset(Offset = "0x60")]
	public Transform digTileAign;

	// Token: 0x0400089B RID: 2203
	[Token(Token = "0x400089B")]
	[FieldOffset(Offset = "0x68")]
	public Transform weaponRight;

	// Token: 0x0400089C RID: 2204
	[Token(Token = "0x400089C")]
	[FieldOffset(Offset = "0x70")]
	public Transform constrainTr;

	// Token: 0x0400089D RID: 2205
	[Token(Token = "0x400089D")]
	[FieldOffset(Offset = "0x78")]
	public Transform lookAtTr;

	// Token: 0x0400089E RID: 2206
	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x80")]
	public Transform spine1;

	// Token: 0x0400089F RID: 2207
	[Token(Token = "0x400089F")]
	[FieldOffset(Offset = "0x88")]
	public Transform spine2;

	// Token: 0x040008A0 RID: 2208
	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x90")]
	public Transform spine3;

	// Token: 0x040008A1 RID: 2209
	[Token(Token = "0x40008A1")]
	[FieldOffset(Offset = "0x98")]
	public Transform playerCam;

	// Token: 0x040008A2 RID: 2210
	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0xA0")]
	public Transform OvrCam;

	// Token: 0x040008A3 RID: 2211
	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0xA8")]
	public Transform camParent;

	// Token: 0x040008A4 RID: 2212
	[Token(Token = "0x40008A4")]
	[FieldOffset(Offset = "0xB0")]
	public Transform hipsJnt;

	// Token: 0x040008A5 RID: 2213
	[Token(Token = "0x40008A5")]
	[FieldOffset(Offset = "0xB8")]
	public Transform head0Jnt;

	// Token: 0x040008A6 RID: 2214
	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0xC0")]
	public Transform headJnt;

	// Token: 0x040008A7 RID: 2215
	[Token(Token = "0x40008A7")]
	[FieldOffset(Offset = "0xC8")]
	public Transform neckJnt;

	// Token: 0x040008A8 RID: 2216
	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0xD0")]
	public Transform neck1Jnt;

	// Token: 0x040008A9 RID: 2217
	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0xD8")]
	public Transform leftHand;

	// Token: 0x040008AA RID: 2218
	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0xE0")]
	public Transform leftHandHeld;

	// Token: 0x040008AB RID: 2219
	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0xE8")]
	public Transform rightHandHeld;

	// Token: 0x040008AC RID: 2220
	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0xF0")]
	public Transform leftHandWrist;

	// Token: 0x040008AD RID: 2221
	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0xF8")]
	public Transform leftArm;

	// Token: 0x040008AE RID: 2222
	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x100")]
	public Transform rightArm;

	// Token: 0x040008AF RID: 2223
	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x108")]
	public Transform rightHandWrist;

	// Token: 0x040008B0 RID: 2224
	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x110")]
	public Transform leftElbowIkTargetLow;

	// Token: 0x040008B1 RID: 2225
	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x118")]
	public GameObject weaponCube;

	// Token: 0x040008B2 RID: 2226
	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x120")]
	public GameObject playerBase;

	// Token: 0x040008B3 RID: 2227
	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x128")]
	public GameObject heldLog1;

	// Token: 0x040008B4 RID: 2228
	[Token(Token = "0x40008B4")]
	[FieldOffset(Offset = "0x130")]
	public GameObject heldLog2;

	// Token: 0x040008B5 RID: 2229
	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0x138")]
	public GameObject heldBow;

	// Token: 0x040008B6 RID: 2230
	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0x140")]
	public GameObject heldBowTip;

	// Token: 0x040008B7 RID: 2231
	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x148")]
	public GameObject heldModernBow;

	// Token: 0x040008B8 RID: 2232
	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x150")]
	public GameObject heldModernBowTip;

	// Token: 0x040008B9 RID: 2233
	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[FormerlySerializedAs("bodyCollisionGo")]
	[FormerlySerializedAs("_hitDetectionGo")]
	private GameObject _damageControllerGo;
}
