using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Sons.Environment;
using Sons.Items.Core;
using Sons.Physics;
using UnityEngine;

// Token: 0x020000FD RID: 253
[Token(Token = "0x20000FD")]
public class animEventsManager : EntityEventListener, IEnvironmentWetnessReceiver
{
	// Token: 0x14000009 RID: 9
	// (add) Token: 0x060007AE RID: 1966 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x060007AF RID: 1967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000009")]
	private event Action NewMeleeSwingEvent
	{
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x367BE70", Offset = "0x367A470", VA = "0x18367BE70")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x367BF60", Offset = "0x367A560", VA = "0x18367BF60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x367C050", Offset = "0x367A650", VA = "0x18367C050")]
	public void AddNewMeleeSwingCallback(Action callback)
	{
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x367BF60", Offset = "0x367A560", VA = "0x18367BF60")]
	public void RemoveNewMeleeSwingCallback(Action callback)
	{
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x367C150", Offset = "0x367A750", VA = "0x18367C150")]
	private void OnDeserialized()
	{
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x367C240", Offset = "0x367A840", VA = "0x18367C240")]
	private void Awake()
	{
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x367C560", Offset = "0x367AB60", VA = "0x18367C560")]
	private ItemGroupEvent[] AllItemGroupEvents()
	{
		return null;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x367C7A0", Offset = "0x367ADA0", VA = "0x18367C7A0")]
	private void Start()
	{
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x367CBF0", Offset = "0x367B1F0", VA = "0x18367CBF0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x367D2B0", Offset = "0x367B8B0", VA = "0x18367D2B0")]
	private void Update()
	{
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x367D4C0", Offset = "0x367BAC0", VA = "0x18367D4C0")]
	private void SetUpWeapons()
	{
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x367D860", Offset = "0x367BE60", VA = "0x18367D860")]
	private void setAttackFalse(bool setAttack)
	{
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x367D8F0", Offset = "0x367BEF0", VA = "0x18367D8F0")]
	public void ShowMudOnShovel()
	{
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x367DA10", Offset = "0x367C010", VA = "0x18367DA10")]
	public void HideMudOnShovel()
	{
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void DiggingFillStart()
	{
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void DiggingFillEnd()
	{
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void DiggingStart()
	{
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void DiggingEnd()
	{
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00004380 File Offset: 0x00002580
	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x367DB30", Offset = "0x367C130", VA = "0x18367DB30")]
	private bool IsLowSwing()
	{
		return default(bool);
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x367DC00", Offset = "0x367C200", VA = "0x18367DC00")]
	private void UpdateCommonWeaponColliders(bool isLowSwing)
	{
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x367E290", Offset = "0x367C890", VA = "0x18367E290")]
	public void MeleeResetDamage()
	{
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x367E2B0", Offset = "0x367C8B0", VA = "0x18367E2B0")]
	public void enableWeapon()
	{
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x367E3C0", Offset = "0x367C9C0", VA = "0x18367E3C0")]
	public void disableWeapon()
	{
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x367E440", Offset = "0x367CA40", VA = "0x18367E440")]
	private void enableWeaponMP()
	{
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x367E510", Offset = "0x367CB10", VA = "0x18367E510")]
	public void disableWeapon2()
	{
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x367E570", Offset = "0x367CB70", VA = "0x18367E570")]
	public void enableSmashWeapon()
	{
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x367E5B0", Offset = "0x367CBB0", VA = "0x18367E5B0")]
	public void disableSmashWeapon()
	{
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x367E630", Offset = "0x367CC30", VA = "0x18367E630")]
	private void doStaminaDrain(float amount)
	{
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x367E6A0", Offset = "0x367CCA0", VA = "0x18367E6A0")]
	private void disableHitFloat()
	{
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x367E700", Offset = "0x367CD00", VA = "0x18367E700")]
	public void setHitDirection(int dir)
	{
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x367E760", Offset = "0x367CD60", VA = "0x18367E760")]
	public void SetBlockRange(bool value)
	{
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x367E7C0", Offset = "0x367CDC0", VA = "0x18367E7C0")]
	public void SetComboTransition(int value)
	{
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x367E820", Offset = "0x367CE20", VA = "0x18367E820")]
	private void PlayWeaponOneshot(string path)
	{
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x367E8C0", Offset = "0x367CEC0", VA = "0x18367E8C0")]
	private void PlayRaftPaddle()
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x367EA90", Offset = "0x367D090", VA = "0x18367EA90")]
	public void MeleeSwingAudio()
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x367EB80", Offset = "0x367D180", VA = "0x18367EB80")]
	private void soundStickSwoosh()
	{
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x367ED40", Offset = "0x367D340", VA = "0x18367ED40")]
	private void soundAxeSwoosh()
	{
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x367EDC0", Offset = "0x367D3C0", VA = "0x18367EDC0")]
	private void soundRockSwoosh()
	{
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x367EE00", Offset = "0x367D400", VA = "0x18367EE00")]
	private void soundSpearSwoosh()
	{
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x367EE40", Offset = "0x367D440", VA = "0x18367EE40")]
	private void soundBreatheIn()
	{
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x367EEF0", Offset = "0x367D4F0", VA = "0x18367EEF0")]
	private void soundBreatheOut()
	{
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x367EFA0", Offset = "0x367D5A0", VA = "0x18367EFA0")]
	private void PlayFallEvent(float fallParameterValue)
	{
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x367F230", Offset = "0x367D830", VA = "0x18367F230", Slot = "194")]
	public override void OnEvent(SfxFallLight evnt)
	{
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x367F240", Offset = "0x367D840", VA = "0x18367F240")]
	private void soundFallLight()
	{
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x367F2D0", Offset = "0x367D8D0", VA = "0x18367F2D0", Slot = "195")]
	public override void OnEvent(SfxFallHeavy evnt)
	{
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x367F2E0", Offset = "0x367D8E0", VA = "0x18367F2E0")]
	private void soundFallHeavy()
	{
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x367F380", Offset = "0x367D980", VA = "0x18367F380")]
	private void playDrawBow()
	{
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x367F440", Offset = "0x367DA40", VA = "0x18367F440")]
	private void resetAnimLayer(int l)
	{
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x367F4C0", Offset = "0x367DAC0", VA = "0x18367F4C0")]
	private void exitClimbRope()
	{
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void enableArmIK()
	{
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x367F520", Offset = "0x367DB20", VA = "0x18367F520")]
	public void disableArmIK()
	{
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x367F550", Offset = "0x367DB50", VA = "0x18367F550")]
	public void disableSpine()
	{
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x367F600", Offset = "0x367DC00", VA = "0x18367F600")]
	public void enableSpine(bool smooth = false)
	{
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x367F730", Offset = "0x367DD30", VA = "0x18367F730")]
	private void enableDrawBowBlend()
	{
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void disableMainRotator()
	{
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void enableMainRotator()
	{
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x367F780", Offset = "0x367DD80", VA = "0x18367F780")]
	private void enableHeavyAttackRange()
	{
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x367F940", Offset = "0x367DF40", VA = "0x18367F940")]
	private void disableHeavyAttackRange()
	{
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x367E630", Offset = "0x367CC30", VA = "0x18367E630")]
	private void staminaDrain(float amount)
	{
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x367FAB0", Offset = "0x367E0B0", VA = "0x18367FAB0")]
	private void lightFire()
	{
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x367FD20", Offset = "0x367E320", VA = "0x18367FD20")]
	[UsedImplicitly]
	public void ResetLegTurns()
	{
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x367FF10", Offset = "0x367E510", VA = "0x18367FF10")]
	public void ThrowSpear()
	{
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void smoothLockCam()
	{
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x3680720", Offset = "0x367ED20", VA = "0x183680720")]
	public IEnumerator smoothDisableSpine()
	{
		return null;
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EE")]
	[Address(RVA = "0x36807B0", Offset = "0x367EDB0", VA = "0x1836807B0")]
	public IEnumerator smoothEnableSpine()
	{
		return null;
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EF")]
	[Address(RVA = "0x3680840", Offset = "0x367EE40", VA = "0x183680840")]
	private IEnumerator drawBowBlend()
	{
		return null;
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F0")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void lockRotation()
	{
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void unlockRotation()
	{
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x36808D0", Offset = "0x367EED0", VA = "0x1836808D0")]
	[UsedImplicitly]
	private IEnumerator axeStuckInGround()
	{
		return null;
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x3680960", Offset = "0x367EF60", VA = "0x183680960")]
	[UsedImplicitly]
	public IEnumerator axeHitTree()
	{
		return null;
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x36809F0", Offset = "0x367EFF0", VA = "0x1836809F0")]
	private IEnumerator fixRotation()
	{
		return null;
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x3680A80", Offset = "0x367F080", VA = "0x183680A80")]
	private void startCheckArms()
	{
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x3680CB0", Offset = "0x367F2B0", VA = "0x183680CB0")]
	private void disableBlockCam()
	{
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x3680D10", Offset = "0x367F310", VA = "0x183680D10")]
	private void disableCutSceneBool()
	{
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x3680D70", Offset = "0x367F370", VA = "0x183680D70")]
	private void setCheckArms()
	{
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x3680DD0", Offset = "0x367F3D0", VA = "0x183680DD0")]
	private void resetCheckArms()
	{
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x3680E60", Offset = "0x367F460", VA = "0x183680E60")]
	private void enableAmmoBallHeld()
	{
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x3680F10", Offset = "0x367F510", VA = "0x183680F10")]
	private void disableAmmoBallHeld()
	{
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x3680F70", Offset = "0x367F570", VA = "0x183680F70")]
	private void leftArmSplash()
	{
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x3681540", Offset = "0x367FB40", VA = "0x183681540")]
	private void rightArmSplash()
	{
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x3681B10", Offset = "0x3680110", VA = "0x183681B10")]
	private void PlayFootstep(Transform footSpawnTransform)
	{
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void PlayFootstepSnow(Transform footSpawnPos)
	{
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x3681F50", Offset = "0x3680550", VA = "0x183681F50")]
	[UsedImplicitly]
	public void StepLeft()
	{
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x3681F60", Offset = "0x3680560", VA = "0x183681F60")]
	[UsedImplicitly]
	public void StepRight()
	{
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[UsedImplicitly]
	public void StepLeftSnow()
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000803")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[UsedImplicitly]
	public void StepRightSnow()
	{
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000804")]
	[Address(RVA = "0x3681F70", Offset = "0x3680570", VA = "0x183681F70")]
	public void BodyFallLand()
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000805")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void LandLight()
	{
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000806")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void LandHeavy()
	{
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x00004398 File Offset: 0x00002598
	[Token(Token = "0x6000807")]
	[Address(RVA = "0x36821C0", Offset = "0x36807C0", VA = "0x1836821C0")]
	private float CalculateSpeedParameter()
	{
		return 0f;
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000808")]
	[Address(RVA = "0x36823E0", Offset = "0x36809E0", VA = "0x1836823E0")]
	private void PlayLandSfxIfRemote()
	{
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000809")]
	[Address(RVA = "0x13428C0", Offset = "0x1340EC0", VA = "0x1813428C0")]
	public void SetWeaponInfo(weaponInfo weaponInfo)
	{
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080A")]
	[Address(RVA = "0x3682610", Offset = "0x3680C10", VA = "0x183682610")]
	public void RegisterCollider(Collider collider, bool lowSwingOnly)
	{
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x36828B0", Offset = "0x3680EB0", VA = "0x1836828B0")]
	public void UnRegisterCollider(Collider collider)
	{
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080C")]
	[Address(RVA = "0x3682A00", Offset = "0x3681000", VA = "0x183682A00", Slot = "322")]
	public void UpdateWetness(float wetnessCurrent)
	{
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080D")]
	[Address(RVA = "0x3682A10", Offset = "0x3681010", VA = "0x183682A10")]
	public animEventsManager()
	{
	}

	// Token: 0x04000627 RID: 1575
	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0x28")]
	public bool Remote;

	// Token: 0x04000628 RID: 1576
	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x30")]
	private Buoyancy buoyancy;

	// Token: 0x04000629 RID: 1577
	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x38")]
	private CoopUnderfootSurface coopUnderfoot;

	// Token: 0x0400062A RID: 1578
	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x40")]
	private Animator _animator;

	// Token: 0x0400062B RID: 1579
	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private simpleIkSolver armIK;

	// Token: 0x0400062C RID: 1580
	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject bowArrow;

	// Token: 0x0400062D RID: 1581
	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x58")]
	public GameObject spearSpawn;

	// Token: 0x0400062E RID: 1582
	[Token(Token = "0x400062E")]
	[FieldOffset(Offset = "0x60")]
	public GameObject spearSpawn_upgraded;

	// Token: 0x0400062F RID: 1583
	[Token(Token = "0x400062F")]
	[FieldOffset(Offset = "0x68")]
	public Transform spearThrowPos;

	// Token: 0x04000630 RID: 1584
	[Token(Token = "0x4000630")]
	[FieldOffset(Offset = "0x70")]
	public Transform spearThrowPos_upgraded;

	// Token: 0x04000631 RID: 1585
	[Token(Token = "0x4000631")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ammoBallHeld;

	// Token: 0x04000632 RID: 1586
	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0x80")]
	public float throwForce;

	// Token: 0x04000633 RID: 1587
	[Token(Token = "0x4000633")]
	[FieldOffset(Offset = "0x84")]
	[ItemIdPicker]
	public int _spearId;

	// Token: 0x04000634 RID: 1588
	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0x88")]
	[ItemIdPicker]
	public int _spearUpgradedId;

	// Token: 0x04000635 RID: 1589
	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0x90")]
	public Transform hitTriggerTr;

	// Token: 0x04000636 RID: 1590
	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0x98")]
	private List<Collider> _registeredWeaponColliders;

	// Token: 0x04000637 RID: 1591
	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0xA0")]
	private List<Collider> _lowSwingWeaponCollider;

	// Token: 0x04000638 RID: 1592
	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0xA8")]
	private weaponInfo _mainWeaponInfo;

	// Token: 0x04000639 RID: 1593
	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0xB0")]
	private bool _weaponCollidersEnabled;

	// Token: 0x0400063A RID: 1594
	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0xB1")]
	private bool _smashWeaponCollidersEnabled;

	// Token: 0x0400063B RID: 1595
	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Collider multiToolShovelCollider;

	// Token: 0x0400063C RID: 1596
	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Collider multiToolShovelFillCollider;

	// Token: 0x0400063D RID: 1597
	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GameObject _shovelMudTarget;

	// Token: 0x0400063E RID: 1598
	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0xD0")]
	public ParticleSystem leafFootParticle;

	// Token: 0x0400063F RID: 1599
	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0xD8")]
	public ParticleSystem snowFootParticle;

	// Token: 0x04000640 RID: 1600
	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0xE0")]
	public ParticleSystem dustFootParticle;

	// Token: 0x04000641 RID: 1601
	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0xE8")]
	public ParticleSystem sandFootParticle;

	// Token: 0x04000642 RID: 1602
	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0xF0")]
	public ParticleSystem waterFootParticle;

	// Token: 0x04000643 RID: 1603
	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0xF8")]
	public ParticleSystem waterLegParticle;

	// Token: 0x04000644 RID: 1604
	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x100")]
	public ParticleSystem waterArmParticle;

	// Token: 0x04000645 RID: 1605
	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x108")]
	public Transform leftFootSpawnPos;

	// Token: 0x04000646 RID: 1606
	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x110")]
	public Transform rightFootSpawnPos;

	// Token: 0x04000647 RID: 1607
	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x118")]
	public Transform leftArmSplashPos;

	// Token: 0x04000648 RID: 1608
	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x120")]
	public Transform rightArmSplashPos;

	// Token: 0x04000649 RID: 1609
	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x128")]
	public Collider underFootCollider;

	// Token: 0x0400064A RID: 1610
	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0x130")]
	public ItemGroupEvent bowDrawEvent;

	// Token: 0x0400064B RID: 1611
	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x138")]
	public ItemGroupEvent stickSwooshEvent;

	// Token: 0x0400064C RID: 1612
	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x140")]
	public ItemGroupEvent axeSwooshEvent;

	// Token: 0x0400064D RID: 1613
	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x148")]
	public ItemGroupEvent rockSwooshEvent;

	// Token: 0x0400064E RID: 1614
	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x150")]
	public ItemGroupEvent spearSwooshEvent;

	// Token: 0x0400064F RID: 1615
	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0x158")]
	public ItemGroupEvent swordSwooshEvent;

	// Token: 0x04000650 RID: 1616
	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x160")]
	public ItemGroupEvent fireStickSwooshEvent;

	// Token: 0x04000651 RID: 1617
	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x168")]
	private Dictionary<int, ItemGroupEvent> eventsByItemIdCache;

	// Token: 0x04000652 RID: 1618
	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0x170")]
	public string breatheInEvent;

	// Token: 0x04000653 RID: 1619
	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x178")]
	public string breatheOutEvent;

	// Token: 0x04000654 RID: 1620
	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x180")]
	public string fallEvent;

	// Token: 0x04000655 RID: 1621
	[Token(Token = "0x4000655")]
	[FieldOffset(Offset = "0x188")]
	public string pushSledEvent;

	// Token: 0x04000656 RID: 1622
	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x190")]
	private float snowStartHeight;

	// Token: 0x04000657 RID: 1623
	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x194")]
	private float snowFadeLength;

	// Token: 0x04000658 RID: 1624
	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x198")]
	private AnimatorStateInfo currState0;

	// Token: 0x04000659 RID: 1625
	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x1BC")]
	private AnimatorStateInfo currState2;

	// Token: 0x0400065A RID: 1626
	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x1E0")]
	private int raftIdleHash;

	// Token: 0x0400065B RID: 1627
	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x1E4")]
	private int raftPaddleHash;

	// Token: 0x0400065C RID: 1628
	[Token(Token = "0x400065C")]
	[FieldOffset(Offset = "0x1E8")]
	private Vector3 previousPosition;

	// Token: 0x0400065D RID: 1629
	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x1F8")]
	public Transform _weaponVelocityTr;

	// Token: 0x0400065E RID: 1630
	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0x200")]
	private Vector3 _prevWepPos;

	// Token: 0x0400065F RID: 1631
	[Token(Token = "0x400065F")]
	[FieldOffset(Offset = "0x20C")]
	private Vector3 _prevWorldWepPos;

	// Token: 0x04000660 RID: 1632
	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x218")]
	private Vector3 _prevWristPos;

	// Token: 0x04000661 RID: 1633
	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0x228")]
	private Vector3[] _startSwingPositions;

	// Token: 0x04000662 RID: 1634
	[Token(Token = "0x4000662")]
	[FieldOffset(Offset = "0x230")]
	private float _vrWeaponAttackWindow;

	// Token: 0x04000663 RID: 1635
	[Token(Token = "0x4000663")]
	[FieldOffset(Offset = "0x234")]
	public float _vrEnableWeaponVelocity;

	// Token: 0x04000664 RID: 1636
	[Token(Token = "0x4000664")]
	[FieldOffset(Offset = "0x238")]
	public float minWristVelocity;

	// Token: 0x04000665 RID: 1637
	[Token(Token = "0x4000665")]
	[FieldOffset(Offset = "0x23C")]
	public float _minArcDistance;

	// Token: 0x04000666 RID: 1638
	[Token(Token = "0x4000666")]
	[FieldOffset(Offset = "0x240")]
	private Vector3 arcStartPosition;

	// Token: 0x04000667 RID: 1639
	[Token(Token = "0x4000667")]
	[FieldOffset(Offset = "0x24C")]
	private float _enableWeaponTimer;

	// Token: 0x04000668 RID: 1640
	[Token(Token = "0x4000668")]
	[FieldOffset(Offset = "0x250")]
	private int _swingPosCounter;

	// Token: 0x04000669 RID: 1641
	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0x254")]
	private int fixedUpdateCount;

	// Token: 0x0400066A RID: 1642
	[Token(Token = "0x400066A")]
	[FieldOffset(Offset = "0x258")]
	[NonSerialized]
	public bool IsSledTurning;

	// Token: 0x0400066C RID: 1644
	[Token(Token = "0x400066C")]
	[FieldOffset(Offset = "0x0")]
	private static int idleToPushSledHash;

	// Token: 0x0400066D RID: 1645
	[Token(Token = "0x400066D")]
	[FieldOffset(Offset = "0x4")]
	private static int pushSledIdleHash;

	// Token: 0x0400066E RID: 1646
	[Token(Token = "0x400066E")]
	[FieldOffset(Offset = "0x8")]
	private static int locomotionHash;

	// Token: 0x0400066F RID: 1647
	[Token(Token = "0x400066F")]
	[FieldOffset(Offset = "0x268")]
	public bool introCutScene;

	// Token: 0x04000670 RID: 1648
	[Token(Token = "0x4000670")]
	[FieldOffset(Offset = "0x26C")]
	private float _wetnessCurrent;
}
