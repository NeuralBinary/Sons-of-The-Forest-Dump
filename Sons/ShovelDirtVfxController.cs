using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Environment.Digging;
using UnityEngine;
using UnityEngine.VFX;

// Token: 0x0200016C RID: 364
[Token(Token = "0x200016C")]
public class ShovelDirtVfxController : MonoBehaviour
{
	// Token: 0x06000B3E RID: 2878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B3E")]
	[Address(RVA = "0x36C9C30", Offset = "0x36C8230", VA = "0x1836C9C30")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x36C9C40", Offset = "0x36C8240", VA = "0x1836C9C40")]
	public void Dispose()
	{
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B40")]
	[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
	public void SetActiveDiggingGroup(DiggingTileGroup target)
	{
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B41")]
	[Address(RVA = "0x36C9F90", Offset = "0x36C8590", VA = "0x1836C9F90")]
	public void UpdateShovelDirtVFX(Vector3 groundPosition, Vector3 velocity)
	{
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B42")]
	[Address(RVA = "0x36CA0E0", Offset = "0x36C86E0", VA = "0x1836CA0E0")]
	public VisualEffect GetDigImpactFX()
	{
		return null;
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x36CA350", Offset = "0x36C8950", VA = "0x1836CA350")]
	public VisualEffect GetGroundHitFX()
	{
		return null;
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x36CA490", Offset = "0x36C8A90", VA = "0x1836CA490")]
	private VisualEffect CreateVfxInstance(VisualEffect vfxPrefab)
	{
		return null;
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x36CA720", Offset = "0x36C8D20", VA = "0x1836CA720")]
	public void SetupVisualEffects(float digDirection, Vector3 attachPos, GameObject attachedObject, int digIndex)
	{
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x36CAFB0", Offset = "0x36C95B0", VA = "0x1836CAFB0")]
	public void Play()
	{
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x36CB0A0", Offset = "0x36C96A0", VA = "0x1836CB0A0")]
	public void SetShovelDirVFXStopTimeStamp(float time)
	{
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x36CB1C0", Offset = "0x36C97C0", VA = "0x1836CB1C0")]
	private IEnumerator StopShovelDirtWorker()
	{
		return null;
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x36CB250", Offset = "0x36C9850", VA = "0x1836CB250")]
	private void StopShovelDirtVfx()
	{
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x36CB380", Offset = "0x36C9980", VA = "0x1836CB380")]
	public ShovelDirtVfxController()
	{
	}

	// Token: 0x040009A5 RID: 2469
	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private VisualEffect _shovelDirtVFX;

	// Token: 0x040009A6 RID: 2470
	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _shovelDirtVFXStop;

	// Token: 0x040009A7 RID: 2471
	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private VisualEffect _brokenGroundVfxObjectPrefab;

	// Token: 0x040009A8 RID: 2472
	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private VisualEffect _groundHitVfxObjectPrefab;

	// Token: 0x040009A9 RID: 2473
	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3 _brokenGroundVfxOffset;

	// Token: 0x040009AA RID: 2474
	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _terrainDigEventName;

	// Token: 0x040009AB RID: 2475
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string _digParticlePositionName;

	// Token: 0x040009AC RID: 2476
	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<KeyFloatPairSet> _digVfxFloats;

	// Token: 0x040009AD RID: 2477
	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<GameObject> _DirtVats;

	// Token: 0x040009AE RID: 2478
	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x70")]
	private DiggingTileGroup _activeDiggingGroup;

	// Token: 0x040009AF RID: 2479
	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x78")]
	private VisualEffect _brokenGroundVfxObject;

	// Token: 0x040009B0 RID: 2480
	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x80")]
	private VisualEffect _groundHitVfxObject;

	// Token: 0x040009B1 RID: 2481
	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x88")]
	private float _shovelDirVFXStopTimeStamp;

	// Token: 0x040009B2 RID: 2482
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x90")]
	private GameObject _attachedObject;

	// Token: 0x040009B3 RID: 2483
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine _stopShovelDirtCoroutine;
}
