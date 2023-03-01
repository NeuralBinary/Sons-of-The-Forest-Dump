using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

// Token: 0x02000058 RID: 88
[Token(Token = "0x2000058")]
[AddComponentMenu("Sons/Ai/Interact/Hug Player Interaction")]
public class HugPlayerInteraction : MonoBehaviour, IVailActorInteract
{
	// Token: 0x06000274 RID: 628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
	private void Awake()
	{
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x2B6DFD0", Offset = "0x2B6CFD0", VA = "0x182B6DFD0")]
	private void Update()
	{
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000276")]
	[Address(RVA = "0x2B6DB80", Offset = "0x2B6CB80", VA = "0x182B6DB80", Slot = "4")]
	public void BeginInteraction(VailActor actor, Action completedCallback, Action interruptedCallback)
	{
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000277")]
	[Address(RVA = "0x2B6DF50", Offset = "0x2B6CF50", VA = "0x182B6DF50", Slot = "5")]
	public void DoInteract(VailActor actor, float deltaTime, Action completedCallback, Action interruptedCallback)
	{
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000278")]
	[Address(RVA = "0x2B6DF60", Offset = "0x2B6CF60", VA = "0x182B6DF60", Slot = "6")]
	public void EndInteraction(VailActor actor, Action completedCallback, Action interruptedCallback)
	{
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000279")]
	[Address(RVA = "0x2B6DFA0", Offset = "0x2B6CFA0", VA = "0x182B6DFA0")]
	public void InterruptInteraction()
	{
	}

	// Token: 0x0600027A RID: 634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027A")]
	[Address(RVA = "0x2B6DBC0", Offset = "0x2B6CBC0", VA = "0x182B6DBC0")]
	private void DisablePlayer(bool disable)
	{
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027B")]
	[Address(RVA = "0x2B6E0A0", Offset = "0x2B6D0A0", VA = "0x182B6E0A0")]
	public HugPlayerInteraction()
	{
	}

	// Token: 0x0400024F RID: 591
	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _cancelActionDelay;

	// Token: 0x04000250 RID: 592
	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _xRange;

	// Token: 0x04000251 RID: 593
	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _yRange;

	// Token: 0x04000252 RID: 594
	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x30")]
	private Action _completedAction;

	// Token: 0x04000253 RID: 595
	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x38")]
	private Action _interruptAction;

	// Token: 0x04000254 RID: 596
	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 _originalCamRotatorRange;

	// Token: 0x04000255 RID: 597
	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 _originalMainRotatorRange;

	// Token: 0x04000256 RID: 598
	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x50")]
	private bool _rotatorValuesStored;
}
