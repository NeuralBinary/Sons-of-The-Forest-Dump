using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002C4 RID: 708
[Token(Token = "0x20002C4")]
[Obsolete]
public class VRTheatreController : MonoBehaviour
{
	// Token: 0x06001225 RID: 4645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001225")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Start()
	{
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001226")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Update()
	{
	}

	// Token: 0x06001227 RID: 4647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001227")]
	[Address(RVA = "0x2B8C800", Offset = "0x2B8B800", VA = "0x182B8C800")]
	public void SwitchToTheatreMode()
	{
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001228")]
	[Address(RVA = "0x2B8BC90", Offset = "0x2B8AC90", VA = "0x182B8BC90")]
	public void SwitchToGameMode()
	{
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001229")]
	[Address(RVA = "0x2B8DB00", Offset = "0x2B8CB00", VA = "0x182B8DB00")]
	public void setCustomGhostPosition(Vector3 pos)
	{
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122A")]
	[Address(RVA = "0x5E65D0", Offset = "0x5E55D0", VA = "0x1805E65D0")]
	private void setVrStandPos1(Transform tr)
	{
	}

	// Token: 0x0600122B RID: 4651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122B")]
	[Address(RVA = "0x5E9640", Offset = "0x5E8640", VA = "0x1805E9640")]
	private void setVrStandPos2(Transform tr)
	{
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122C")]
	[Address(RVA = "0x2B8DA20", Offset = "0x2B8CA20", VA = "0x182B8DA20")]
	private void goToNextVrPos()
	{
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122D")]
	[Address(RVA = "0x2B8DB20", Offset = "0x2B8CB20", VA = "0x182B8DB20")]
	private void useSteppedGhostMode()
	{
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122E")]
	[Address(RVA = "0x2B8D990", Offset = "0x2B8C990", VA = "0x182B8D990")]
	public VRTheatreController()
	{
	}

	// Token: 0x04001218 RID: 4632
	[Token(Token = "0x4001218")]
	[FieldOffset(Offset = "0x20")]
	public Camera SourceCamera;

	// Token: 0x04001219 RID: 4633
	[Token(Token = "0x4001219")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TheatreObject;

	// Token: 0x0400121A RID: 4634
	[Token(Token = "0x400121A")]
	[FieldOffset(Offset = "0x30")]
	public RenderTexture TheatreRT;

	// Token: 0x0400121B RID: 4635
	[Token(Token = "0x400121B")]
	[FieldOffset(Offset = "0x38")]
	public Transform TheatrePosTransform;

	// Token: 0x0400121C RID: 4636
	[Token(Token = "0x400121C")]
	[FieldOffset(Offset = "0x40")]
	public Transform InventoryBone;

	// Token: 0x0400121D RID: 4637
	[Token(Token = "0x400121D")]
	[FieldOffset(Offset = "0x48")]
	public Transform vrPos1;

	// Token: 0x0400121E RID: 4638
	[Token(Token = "0x400121E")]
	[FieldOffset(Offset = "0x50")]
	public Transform vrPos2;

	// Token: 0x0400121F RID: 4639
	[Token(Token = "0x400121F")]
	[FieldOffset(Offset = "0x58")]
	public float SteppedModeUpdateDistance;

	// Token: 0x04001220 RID: 4640
	[Token(Token = "0x4001220")]
	[FieldOffset(Offset = "0x5C")]
	public LayerMask TheatreCullingMask;

	// Token: 0x04001221 RID: 4641
	[Token(Token = "0x4001221")]
	[FieldOffset(Offset = "0x60")]
	public LayerMask DefaultLayerMask;

	// Token: 0x04001222 RID: 4642
	[Token(Token = "0x4001222")]
	[FieldOffset(Offset = "0x64")]
	public LayerMask OptionsMenuLayerMask;

	// Token: 0x04001223 RID: 4643
	[Token(Token = "0x4001223")]
	[FieldOffset(Offset = "0x68")]
	public VRVignetteController VignetteController;

	// Token: 0x04001224 RID: 4644
	[Token(Token = "0x4001224")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 storeVrOffsetPos;

	// Token: 0x04001225 RID: 4645
	[Token(Token = "0x4001225")]
	[FieldOffset(Offset = "0x7C")]
	public bool useCustomPosition;

	// Token: 0x04001226 RID: 4646
	[Token(Token = "0x4001226")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 customStandPos;

	// Token: 0x04001227 RID: 4647
	[Token(Token = "0x4001227")]
	[FieldOffset(Offset = "0x8C")]
	public float offsetRigHeight;

	// Token: 0x04001228 RID: 4648
	[Token(Token = "0x4001228")]
	[FieldOffset(Offset = "0x90")]
	public bool ghostFromIkDisable;

	// Token: 0x04001229 RID: 4649
	[Token(Token = "0x4001229")]
	[FieldOffset(Offset = "0x91")]
	public bool ghostFromTheatreMode;

	// Token: 0x0400122A RID: 4650
	[Token(Token = "0x400122A")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 _cameraOffset;

	// Token: 0x0400122B RID: 4651
	[Token(Token = "0x400122B")]
	[FieldOffset(Offset = "0xA0")]
	public bool theatreOn;

	// Token: 0x0400122C RID: 4652
	[Token(Token = "0x400122C")]
	[FieldOffset(Offset = "0xA1")]
	private bool steppedMode;

	// Token: 0x0400122D RID: 4653
	[Token(Token = "0x400122D")]
	[FieldOffset(Offset = "0xA2")]
	public bool comfortMode;

	// Token: 0x0400122E RID: 4654
	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0xA8")]
	private List<VRTheatreController.TrackedRenderSettings> _trackedRendererModifications;

	// Token: 0x020002C5 RID: 709
	[Token(Token = "0x20002C5")]
	public class TrackedRenderSettings
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020C")]
		public Renderer Renderer
		{
			[Token(Token = "0x600122F")]
			[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x1700020D")]
		public ShadowCastingMode ShadowCastingMode
		{
			[Token(Token = "0x6001230")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return default(ShadowCastingMode);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00006318 File Offset: 0x00004518
		[Token(Token = "0x1700020E")]
		public int Layer
		{
			[Token(Token = "0x6001231")]
			[Address(RVA = "0x6C5570", Offset = "0x6C4570", VA = "0x1806C5570")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001232")]
		[Address(RVA = "0x2B86F70", Offset = "0x2B85F70", VA = "0x182B86F70")]
		public TrackedRenderSettings(Renderer renderer)
		{
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001233")]
		[Address(RVA = "0x2B86EC0", Offset = "0x2B85EC0", VA = "0x182B86EC0")]
		public void Revert()
		{
		}

		// Token: 0x0400122F RID: 4655
		[Token(Token = "0x400122F")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool _valid;

		// Token: 0x04001230 RID: 4656
		[Token(Token = "0x4001230")]
		[FieldOffset(Offset = "0x18")]
		private readonly Renderer _renderer;

		// Token: 0x04001231 RID: 4657
		[Token(Token = "0x4001231")]
		[FieldOffset(Offset = "0x20")]
		private readonly ShadowCastingMode _shadowCastingMode;

		// Token: 0x04001232 RID: 4658
		[Token(Token = "0x4001232")]
		[FieldOffset(Offset = "0x24")]
		private readonly int _layer;
	}
}
