using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005A RID: 90
[Token(Token = "0x200005A")]
public interface IGolfCartState : IState, IDisposable
{
	// Token: 0x17000199 RID: 409
	// (get) Token: 0x0600031E RID: 798
	[Token(Token = "0x17000199")]
	NetworkTransform Transform { [Token(Token = "0x600031E")] get; }

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x0600031F RID: 799
	// (set) Token: 0x06000320 RID: 800
	[Token(Token = "0x1700019A")]
	Vector3 Velocity { [Token(Token = "0x600031F")] get; [Token(Token = "0x6000320")] set; }

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000321 RID: 801
	[Token(Token = "0x1700019B")]
	NetworkTransform FrontLeftWheel { [Token(Token = "0x6000321")] get; }

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000322 RID: 802
	[Token(Token = "0x1700019C")]
	NetworkTransform FrontRightWheel { [Token(Token = "0x6000322")] get; }

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06000323 RID: 803
	[Token(Token = "0x1700019D")]
	NetworkTransform BackLeftWheel { [Token(Token = "0x6000323")] get; }

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06000324 RID: 804
	[Token(Token = "0x1700019E")]
	NetworkTransform BackRightWheel { [Token(Token = "0x6000324")] get; }

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000325 RID: 805
	// (set) Token: 0x06000326 RID: 806
	[Token(Token = "0x1700019F")]
	float SteeringWheelRotation { [Token(Token = "0x6000325")] get; [Token(Token = "0x6000326")] set; }

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06000327 RID: 807
	[Token(Token = "0x170001A0")]
	NetworkArray_Entity ConnectedSlots { [Token(Token = "0x6000327")] get; }

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x06000328 RID: 808
	// (set) Token: 0x06000329 RID: 809
	[Token(Token = "0x170001A1")]
	float FrontLeftWheelRpm { [Token(Token = "0x6000328")] get; [Token(Token = "0x6000329")] set; }

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x0600032A RID: 810
	// (set) Token: 0x0600032B RID: 811
	[Token(Token = "0x170001A2")]
	float FrontRightWheelRpm { [Token(Token = "0x600032A")] get; [Token(Token = "0x600032B")] set; }

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x0600032C RID: 812
	// (set) Token: 0x0600032D RID: 813
	[Token(Token = "0x170001A3")]
	float BackLeftWheelRpm { [Token(Token = "0x600032C")] get; [Token(Token = "0x600032D")] set; }

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x0600032E RID: 814
	// (set) Token: 0x0600032F RID: 815
	[Token(Token = "0x170001A4")]
	float BackRightRpm { [Token(Token = "0x600032E")] get; [Token(Token = "0x600032F")] set; }

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000330 RID: 816
	// (set) Token: 0x06000331 RID: 817
	[Token(Token = "0x170001A5")]
	float Power { [Token(Token = "0x6000330")] get; [Token(Token = "0x6000331")] set; }
}
