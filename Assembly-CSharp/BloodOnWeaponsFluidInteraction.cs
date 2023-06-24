using System;
using System.Collections.Generic;
using FluidSimulation;
using Il2CppDummyDll;
using Sons.Environment;
using Sons.Interfaces;
using Sons.Items.Core;
using TheForest.World;
using UnityEngine;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
[AddComponentMenu("Sons/Blood/Blood On Weapons Fluid Interaction")]
public class BloodOnWeaponsFluidInteraction : MonoBehaviour, IEnvironmentWetnessReceiver, IWetable, IBloodReceiver
{
	// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x5CEE50", Offset = "0x5CD450", VA = "0x1805CEE50")]
	private void Start()
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x5CF090", Offset = "0x5CD690", VA = "0x1805CF090")]
	private void OnRenderableLoaded(Transform renderableTransform)
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x5CF1E0", Offset = "0x5CD7E0", VA = "0x1805CF1E0")]
	private WeatherSystem WeatherSystem()
	{
		return null;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x5CF350", Offset = "0x5CD950", VA = "0x1805CF350")]
	private void OnEnable()
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x5CF440", Offset = "0x5CDA40", VA = "0x1805CF440")]
	private void OnDisable()
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x5CF530", Offset = "0x5CDB30", VA = "0x1805CF530", Slot = "6")]
	public void GotBloody(Vector3 bloodSourcePosition)
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x5D0110", Offset = "0x5CE710", VA = "0x1805D0110")]
	private void Splatter(Transform splatterTransform)
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x5D0ED0", Offset = "0x5CF4D0", VA = "0x1805D0ED0", Slot = "5")]
	public void GotClean()
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x5D0EE0", Offset = "0x5CF4E0", VA = "0x1805D0EE0", Slot = "4")]
	public void UpdateWetness(float wetnessCurrent)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x5D1130", Offset = "0x5CF730", VA = "0x1805D1130")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x5D1720", Offset = "0x5CFD20", VA = "0x1805D1720")]
	public BloodOnWeaponsFluidInteraction()
	{
	}

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x20")]
	public ItemRenderable _itemRenderable;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x28")]
	public Transform _weaponRootTransform;

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x30")]
	public Collider _weaponCollider;

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x38")]
	public LayerMask _weaponLayerMask;

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x40")]
	public Texture2D _bloodTexture;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x48")]
	public float _radius;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x4C")]
	public float _amount;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x50")]
	public float _maxCleanRateWhenWet;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform[] _splatterPoints;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _bloodSprayConeAngleDegrees;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private int _splatterCount;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x68")]
	private bool _showSplatterLinesDebug;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x70")]
	private FluidSimulator _fluidSimulator;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x78")]
	private List<FluidSimulator> _fluidSimulators;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x80")]
	private WeatherSystem _weatherSystem;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x88")]
	private bool _isReady;
}
