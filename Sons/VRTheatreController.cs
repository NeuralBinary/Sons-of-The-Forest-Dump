using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002B8 RID: 696
[Token(Token = "0x20002B8")]
[Obsolete]
public class VRTheatreController : MonoBehaviour
{
	// Token: 0x0600125A RID: 4698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Start()
	{
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Update()
	{
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125C")]
	[Address(RVA = "0x31D85E0", Offset = "0x31D6BE0", VA = "0x1831D85E0")]
	public void SwitchToTheatreMode()
	{
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125D")]
	[Address(RVA = "0x31DA090", Offset = "0x31D8690", VA = "0x1831DA090")]
	public void SwitchToGameMode()
	{
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125E")]
	[Address(RVA = "0x31DB4D0", Offset = "0x31D9AD0", VA = "0x1831DB4D0")]
	public void setCustomGhostPosition(Vector3 pos)
	{
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125F")]
	[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
	private void setVrStandPos1(Transform tr)
	{
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001260")]
	[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
	private void setVrStandPos2(Transform tr)
	{
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001261")]
	[Address(RVA = "0x31DB4F0", Offset = "0x31D9AF0", VA = "0x1831DB4F0")]
	private void goToNextVrPos()
	{
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001262")]
	[Address(RVA = "0x31DB6C0", Offset = "0x31D9CC0", VA = "0x1831DB6C0")]
	private void useSteppedGhostMode()
	{
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001263")]
	[Address(RVA = "0x31DB940", Offset = "0x31D9F40", VA = "0x1831DB940")]
	public VRTheatreController()
	{
	}

	// Token: 0x0400123F RID: 4671
	[Token(Token = "0x400123F")]
	[FieldOffset(Offset = "0x20")]
	public Camera SourceCamera;

	// Token: 0x04001240 RID: 4672
	[Token(Token = "0x4001240")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TheatreObject;

	// Token: 0x04001241 RID: 4673
	[Token(Token = "0x4001241")]
	[FieldOffset(Offset = "0x30")]
	public RenderTexture TheatreRT;

	// Token: 0x04001242 RID: 4674
	[Token(Token = "0x4001242")]
	[FieldOffset(Offset = "0x38")]
	public Transform TheatrePosTransform;

	// Token: 0x04001243 RID: 4675
	[Token(Token = "0x4001243")]
	[FieldOffset(Offset = "0x40")]
	public Transform InventoryBone;

	// Token: 0x04001244 RID: 4676
	[Token(Token = "0x4001244")]
	[FieldOffset(Offset = "0x48")]
	public Transform vrPos1;

	// Token: 0x04001245 RID: 4677
	[Token(Token = "0x4001245")]
	[FieldOffset(Offset = "0x50")]
	public Transform vrPos2;

	// Token: 0x04001246 RID: 4678
	[Token(Token = "0x4001246")]
	[FieldOffset(Offset = "0x58")]
	public float SteppedModeUpdateDistance;

	// Token: 0x04001247 RID: 4679
	[Token(Token = "0x4001247")]
	[FieldOffset(Offset = "0x5C")]
	public LayerMask TheatreCullingMask;

	// Token: 0x04001248 RID: 4680
	[Token(Token = "0x4001248")]
	[FieldOffset(Offset = "0x60")]
	public LayerMask DefaultLayerMask;

	// Token: 0x04001249 RID: 4681
	[Token(Token = "0x4001249")]
	[FieldOffset(Offset = "0x64")]
	public LayerMask OptionsMenuLayerMask;

	// Token: 0x0400124A RID: 4682
	[Token(Token = "0x400124A")]
	[FieldOffset(Offset = "0x68")]
	public VRVignetteController VignetteController;

	// Token: 0x0400124B RID: 4683
	[Token(Token = "0x400124B")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 storeVrOffsetPos;

	// Token: 0x0400124C RID: 4684
	[Token(Token = "0x400124C")]
	[FieldOffset(Offset = "0x7C")]
	public bool useCustomPosition;

	// Token: 0x0400124D RID: 4685
	[Token(Token = "0x400124D")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 customStandPos;

	// Token: 0x0400124E RID: 4686
	[Token(Token = "0x400124E")]
	[FieldOffset(Offset = "0x8C")]
	public float offsetRigHeight;

	// Token: 0x0400124F RID: 4687
	[Token(Token = "0x400124F")]
	[FieldOffset(Offset = "0x90")]
	public bool ghostFromIkDisable;

	// Token: 0x04001250 RID: 4688
	[Token(Token = "0x4001250")]
	[FieldOffset(Offset = "0x91")]
	public bool ghostFromTheatreMode;

	// Token: 0x04001251 RID: 4689
	[Token(Token = "0x4001251")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 _cameraOffset;

	// Token: 0x04001252 RID: 4690
	[Token(Token = "0x4001252")]
	[FieldOffset(Offset = "0xA0")]
	public bool theatreOn;

	// Token: 0x04001253 RID: 4691
	[Token(Token = "0x4001253")]
	[FieldOffset(Offset = "0xA1")]
	private bool steppedMode;

	// Token: 0x04001254 RID: 4692
	[Token(Token = "0x4001254")]
	[FieldOffset(Offset = "0xA2")]
	public bool comfortMode;

	// Token: 0x04001255 RID: 4693
	[Token(Token = "0x4001255")]
	[FieldOffset(Offset = "0xA8")]
	private List<VRTheatreController.TrackedRenderSettings> _trackedRendererModifications;

	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x20002B9")]
	public class TrackedRenderSettings
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000215")]
		public Renderer Renderer
		{
			[Token(Token = "0x6001264")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00006588 File Offset: 0x00004788
		[Token(Token = "0x17000216")]
		public ShadowCastingMode ShadowCastingMode
		{
			[Token(Token = "0x6001265")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return ShadowCastingMode.Off;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x000065A0 File Offset: 0x000047A0
		[Token(Token = "0x17000217")]
		public int Layer
		{
			[Token(Token = "0x6001266")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x31DBA30", Offset = "0x31DA030", VA = "0x1831DBA30")]
		public TrackedRenderSettings(Renderer renderer)
		{
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001268")]
		[Address(RVA = "0x31DBC20", Offset = "0x31DA220", VA = "0x1831DBC20")]
		public void Revert()
		{
		}

		// Token: 0x04001256 RID: 4694
		[Token(Token = "0x4001256")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool _valid;

		// Token: 0x04001257 RID: 4695
		[Token(Token = "0x4001257")]
		[FieldOffset(Offset = "0x18")]
		private readonly Renderer _renderer;

		// Token: 0x04001258 RID: 4696
		[Token(Token = "0x4001258")]
		[FieldOffset(Offset = "0x20")]
		private readonly ShadowCastingMode _shadowCastingMode;

		// Token: 0x04001259 RID: 4697
		[Token(Token = "0x4001259")]
		[FieldOffset(Offset = "0x24")]
		private readonly int _layer;
	}
}
