using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Environment.Digging;
using UnityEngine;
using UnityEngine.VFX;

// Token: 0x0200016D RID: 365
[Token(Token = "0x200016D")]
public class ShovelDirtVfxController : MonoBehaviour
{
	// Token: 0x06000AE5 RID: 2789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x2F53DD0", Offset = "0x2F52DD0", VA = "0x182F53DD0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x2F53DD0", Offset = "0x2F52DD0", VA = "0x182F53DD0")]
	public void Dispose()
	{
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE7")]
	[Address(RVA = "0x656140", Offset = "0x655140", VA = "0x180656140")]
	public void SetActiveDiggingGroup(DiggingTileGroup target)
	{
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE8")]
	[Address(RVA = "0x2F54850", Offset = "0x2F53850", VA = "0x182F54850")]
	public void UpdateShovelDirtVFX(Vector3 groundPosition, Vector3 velocity)
	{
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AE9")]
	[Address(RVA = "0x2F53F20", Offset = "0x2F52F20", VA = "0x182F53F20")]
	public VisualEffect GetDigImpactFX()
	{
		return null;
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0x2F54030", Offset = "0x2F53030", VA = "0x182F54030")]
	public VisualEffect GetGroundHitFX()
	{
		return null;
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0x2F53C30", Offset = "0x2F52C30", VA = "0x182F53C30")]
	private VisualEffect CreateVfxInstance(VisualEffect vfxPrefab)
	{
		return null;
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0x2F541F0", Offset = "0x2F531F0", VA = "0x182F541F0")]
	public void SetupVisualEffects(float digDirection, Vector3 attachPos, GameObject attachedObject, int digIndex)
	{
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x2F540D0", Offset = "0x2F530D0", VA = "0x182F540D0")]
	public void Play()
	{
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x2F54160", Offset = "0x2F53160", VA = "0x182F54160")]
	public void SetShovelDirVFXStopTimeStamp(float time)
	{
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x2F547E0", Offset = "0x2F537E0", VA = "0x182F547E0")]
	private IEnumerator StopShovelDirtWorker()
	{
		return null;
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0x2F54740", Offset = "0x2F53740", VA = "0x182F54740")]
	private void StopShovelDirtVfx()
	{
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x2F54950", Offset = "0x2F53950", VA = "0x182F54950")]
	public ShovelDirtVfxController()
	{
	}

	// Token: 0x0400097C RID: 2428
	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private VisualEffect _shovelDirtVFX;

	// Token: 0x0400097D RID: 2429
	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _shovelDirtVFXStop;

	// Token: 0x0400097E RID: 2430
	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private VisualEffect _brokenGroundVfxObjectPrefab;

	// Token: 0x0400097F RID: 2431
	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private VisualEffect _groundHitVfxObjectPrefab;

	// Token: 0x04000980 RID: 2432
	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3 _brokenGroundVfxOffset;

	// Token: 0x04000981 RID: 2433
	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string _terrainDigEventName;

	// Token: 0x04000982 RID: 2434
	[Token(Token = "0x4000982")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string _digParticlePositionName;

	// Token: 0x04000983 RID: 2435
	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<KeyFloatPairSet> _digVfxFloats;

	// Token: 0x04000984 RID: 2436
	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<GameObject> _DirtVats;

	// Token: 0x04000985 RID: 2437
	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0x70")]
	private DiggingTileGroup _activeDiggingGroup;

	// Token: 0x04000986 RID: 2438
	[Token(Token = "0x4000986")]
	[FieldOffset(Offset = "0x78")]
	private VisualEffect _brokenGroundVfxObject;

	// Token: 0x04000987 RID: 2439
	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0x80")]
	private VisualEffect _groundHitVfxObject;

	// Token: 0x04000988 RID: 2440
	[Token(Token = "0x4000988")]
	[FieldOffset(Offset = "0x88")]
	private float _shovelDirVFXStopTimeStamp;

	// Token: 0x04000989 RID: 2441
	[Token(Token = "0x4000989")]
	[FieldOffset(Offset = "0x90")]
	private GameObject _attachedObject;

	// Token: 0x0400098A RID: 2442
	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine _stopShovelDirtCoroutine;
}
