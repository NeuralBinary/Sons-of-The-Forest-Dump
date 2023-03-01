using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using FMOD.Studio;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Sons.Environment;
using Sons.Items.Core;
using Sons.Physics;
using UnityEngine;

// Token: 0x02000100 RID: 256
[Token(Token = "0x2000100")]
public class animEventsManager : EntityEventListener, IEnvironmentWetnessReceiver
{
	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06000766 RID: 1894 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000767 RID: 1895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000006")]
	private event Action NewMeleeSwingEvent
	{
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x2F42CB0", Offset = "0x2F41CB0", VA = "0x182F42CB0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2F40FA0", Offset = "0x2F3FFA0", VA = "0x182F40FA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000768")]
	[Address(RVA = "0x2F3F750", Offset = "0x2F3E750", VA = "0x182F3F750")]
	public void AddNewMeleeSwingCallback(Action callback)
	{
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000769")]
	[Address(RVA = "0x2F40FA0", Offset = "0x2F3FFA0", VA = "0x182F40FA0")]
	public void RemoveNewMeleeSwingCallback(Action callback)
	{
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600076A")]
	[Address(RVA = "0x2F404C0", Offset = "0x2F3F4C0", VA = "0x182F404C0")]
	private void OnDeserialized()
	{
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600076B")]
	[Address(RVA = "0x2F3FB00", Offset = "0x2F3EB00", VA = "0x182F3FB00")]
	private void Awake()
	{
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076C")]
	[Address(RVA = "0x2F3F870", Offset = "0x2F3E870", VA = "0x182F3F870")]
	private ItemGroupEvent[] AllItemGroupEvents()
	{
		return null;
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600076D")]
	[Address(RVA = "0x2F41530", Offset = "0x2F40530", VA = "0x182F41530")]
	private void Start()
	{
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600076E")]
	[Address(RVA = "0x2F3FD90", Offset = "0x2F3ED90", VA = "0x182F3FD90")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600076F")]
	[Address(RVA = "0x2F429E0", Offset = "0x2F419E0", VA = "0x182F429E0")]
	private void Update()
	{
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000770")]
	[Address(RVA = "0x2F42550", Offset = "0x2F41550", VA = "0x182F42550")]
	private void UpdateSledEvent()
	{
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000771")]
	[Address(RVA = "0x2F41280", Offset = "0x2F40280", VA = "0x182F41280")]
	private void SetUpWeapons()
	{
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000772")]
	[Address(RVA = "0x2F44170", Offset = "0x2F43170", VA = "0x182F44170")]
	private void setAttackFalse(bool setAttack)
	{
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000773")]
	[Address(RVA = "0x2F414B0", Offset = "0x2F404B0", VA = "0x182F414B0")]
	public void ShowMudOnShovel()
	{
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000774")]
	[Address(RVA = "0x2F40310", Offset = "0x2F3F310", VA = "0x182F40310")]
	public void HideMudOnShovel()
	{
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000775")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void DiggingFillStart()
	{
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void DiggingFillEnd()
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000777")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void DiggingStart()
	{
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000778")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void DiggingEnd()
	{
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00004170 File Offset: 0x00002370
	[Token(Token = "0x6000779")]
	[Address(RVA = "0x2F40390", Offset = "0x2F3F390", VA = "0x182F40390")]
	private bool IsLowSwing()
	{
		return default(bool);
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077A")]
	[Address(RVA = "0x2F41FF0", Offset = "0x2F40FF0", VA = "0x182F41FF0")]
	private void UpdateCommonWeaponColliders(bool isLowSwing)
	{
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077B")]
	[Address(RVA = "0x2F40400", Offset = "0x2F3F400", VA = "0x182F40400")]
	public void MeleeResetDamage()
	{
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077C")]
	[Address(RVA = "0x2F43690", Offset = "0x2F42690", VA = "0x182F43690")]
	public void enableWeapon()
	{
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077D")]
	[Address(RVA = "0x2F431A0", Offset = "0x2F421A0", VA = "0x182F431A0")]
	public void disableWeapon()
	{
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077E")]
	[Address(RVA = "0x2F43570", Offset = "0x2F42570", VA = "0x182F43570")]
	private void enableWeaponMP()
	{
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077F")]
	[Address(RVA = "0x2F43140", Offset = "0x2F42140", VA = "0x182F43140")]
	public void disableWeapon2()
	{
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000780")]
	[Address(RVA = "0x2F43490", Offset = "0x2F42490", VA = "0x182F43490")]
	public void enableSmashWeapon()
	{
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000781")]
	[Address(RVA = "0x2F43050", Offset = "0x2F42050", VA = "0x182F43050")]
	public void disableSmashWeapon()
	{
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000782")]
	[Address(RVA = "0x2F43220", Offset = "0x2F42220", VA = "0x182F43220")]
	private void doStaminaDrain(float amount)
	{
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000783")]
	[Address(RVA = "0x2F43000", Offset = "0x2F42000", VA = "0x182F43000")]
	private void disableHitFloat()
	{
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000784")]
	[Address(RVA = "0x2F44240", Offset = "0x2F43240", VA = "0x182F44240")]
	public void setHitDirection(int dir)
	{
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000785")]
	[Address(RVA = "0x2F411C0", Offset = "0x2F401C0", VA = "0x182F411C0")]
	public void SetBlockRange(bool value)
	{
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000786")]
	[Address(RVA = "0x2F41220", Offset = "0x2F40220", VA = "0x182F41220")]
	public void SetComboTransition(int value)
	{
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000787")]
	[Address(RVA = "0x2F40CD0", Offset = "0x2F3FCD0", VA = "0x182F40CD0")]
	private void PlayWeaponOneshot(string path)
	{
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000788")]
	[Address(RVA = "0x2F40BC0", Offset = "0x2F3FBC0", VA = "0x182F40BC0")]
	private void PlayRaftPaddle()
	{
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000789")]
	[Address(RVA = "0x2F40420", Offset = "0x2F3F420", VA = "0x182F40420")]
	public void MeleeSwingAudio()
	{
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078A")]
	[Address(RVA = "0x2F446B0", Offset = "0x2F436B0", VA = "0x182F446B0")]
	private void soundStickSwoosh()
	{
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078B")]
	[Address(RVA = "0x2F44380", Offset = "0x2F43380", VA = "0x182F44380")]
	private void soundAxeSwoosh()
	{
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078C")]
	[Address(RVA = "0x2F44630", Offset = "0x2F43630", VA = "0x182F44630")]
	private void soundRockSwoosh()
	{
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078D")]
	[Address(RVA = "0x2F44670", Offset = "0x2F43670", VA = "0x182F44670")]
	private void soundSpearSwoosh()
	{
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078E")]
	[Address(RVA = "0x2F44400", Offset = "0x2F43400", VA = "0x182F44400")]
	private void soundBreatheIn()
	{
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078F")]
	[Address(RVA = "0x2F44480", Offset = "0x2F43480", VA = "0x182F44480")]
	private void soundBreatheOut()
	{
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000790")]
	[Address(RVA = "0x2F40560", Offset = "0x2F3F560", VA = "0x182F40560")]
	private void PlayFallEvent(float fallParameterValue)
	{
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000791")]
	[Address(RVA = "0x2F40540", Offset = "0x2F3F540", VA = "0x182F40540", Slot = "181")]
	public override void OnEvent(SfxFallLight evnt)
	{
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000792")]
	[Address(RVA = "0x2F445A0", Offset = "0x2F435A0", VA = "0x182F445A0")]
	private void soundFallLight()
	{
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000793")]
	[Address(RVA = "0x2F40550", Offset = "0x2F3F550", VA = "0x182F40550", Slot = "182")]
	public override void OnEvent(SfxFallHeavy evnt)
	{
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000794")]
	[Address(RVA = "0x2F44500", Offset = "0x2F43500", VA = "0x182F44500")]
	private void soundFallHeavy()
	{
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000795")]
	[Address(RVA = "0x2F43CB0", Offset = "0x2F42CB0", VA = "0x182F43CB0")]
	private void playDrawBow()
	{
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000796")]
	[Address(RVA = "0x2F43D70", Offset = "0x2F42D70", VA = "0x182F43D70")]
	private void resetAnimLayer(int l)
	{
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000797")]
	[Address(RVA = "0x2F43730", Offset = "0x2F42730", VA = "0x182F43730")]
	private void exitClimbRope()
	{
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000798")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void enableArmIK()
	{
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000799")]
	[Address(RVA = "0x2F42E60", Offset = "0x2F41E60", VA = "0x182F42E60")]
	public void disableArmIK()
	{
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079A")]
	[Address(RVA = "0x2F430D0", Offset = "0x2F420D0", VA = "0x182F430D0")]
	public void disableSpine()
	{
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079B")]
	[Address(RVA = "0x2F434D0", Offset = "0x2F424D0", VA = "0x182F434D0")]
	public void enableSpine(bool smooth = false)
	{
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079C")]
	[Address(RVA = "0x2F43360", Offset = "0x2F42360", VA = "0x182F43360")]
	private void enableDrawBowBlend()
	{
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079D")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void disableMainRotator()
	{
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079E")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void enableMainRotator()
	{
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079F")]
	[Address(RVA = "0x2F433B0", Offset = "0x2F423B0", VA = "0x182F433B0")]
	private void enableHeavyAttackRange()
	{
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x2F42F50", Offset = "0x2F41F50", VA = "0x182F42F50")]
	private void disableHeavyAttackRange()
	{
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x2F43220", Offset = "0x2F42220", VA = "0x182F43220")]
	private void staminaDrain(float amount)
	{
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x2F43B60", Offset = "0x2F42B60", VA = "0x182F43B60")]
	private void lightFire()
	{
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x2F41040", Offset = "0x2F40040", VA = "0x182F41040")]
	[UsedImplicitly]
	public void ResetLegTurns()
	{
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x2F418A0", Offset = "0x2F408A0", VA = "0x182F418A0")]
	public void ThrowSpear()
	{
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void smoothLockCam()
	{
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A6")]
	[Address(RVA = "0x2F442A0", Offset = "0x2F432A0", VA = "0x182F442A0")]
	public IEnumerator smoothDisableSpine()
	{
		return null;
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x2F44310", Offset = "0x2F43310", VA = "0x182F44310")]
	public IEnumerator smoothEnableSpine()
	{
		return null;
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x2F43290", Offset = "0x2F42290", VA = "0x182F43290")]
	private IEnumerator drawBowBlend()
	{
		return null;
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void lockRotation()
	{
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void unlockRotation()
	{
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x2F42DC0", Offset = "0x2F41DC0", VA = "0x182F42DC0")]
	[UsedImplicitly]
	private IEnumerator axeStuckInGround()
	{
		return null;
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x2F42D50", Offset = "0x2F41D50", VA = "0x182F42D50")]
	[UsedImplicitly]
	public IEnumerator axeHitTree()
	{
		return null;
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x2F43790", Offset = "0x2F42790", VA = "0x182F43790")]
	private IEnumerator fixRotation()
	{
		return null;
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x2F44870", Offset = "0x2F43870", VA = "0x182F44870")]
	private void startCheckArms()
	{
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x2F42E90", Offset = "0x2F41E90", VA = "0x182F42E90")]
	private void disableBlockCam()
	{
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x2F42EF0", Offset = "0x2F41EF0", VA = "0x182F42EF0")]
	private void disableCutSceneBool()
	{
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x2F441F0", Offset = "0x2F431F0", VA = "0x182F441F0")]
	private void setCheckArms()
	{
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x2F43D90", Offset = "0x2F42D90", VA = "0x182F43D90")]
	private void resetCheckArms()
	{
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x2F43300", Offset = "0x2F42300", VA = "0x182F43300")]
	private void enableAmmoBallHeld()
	{
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x2F42E30", Offset = "0x2F41E30", VA = "0x182F42E30")]
	private void disableAmmoBallHeld()
	{
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x2F43800", Offset = "0x2F42800", VA = "0x182F43800")]
	private void leftArmSplash()
	{
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x2F43E10", Offset = "0x2F42E10", VA = "0x182F43E10")]
	private void rightArmSplash()
	{
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x2F406D0", Offset = "0x2F3F6D0", VA = "0x182F406D0")]
	private void PlayFootstep(Transform footSpawnTransform)
	{
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void PlayFootstepSnow(Transform footSpawnPos)
	{
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x2F41880", Offset = "0x2F40880", VA = "0x182F41880")]
	[UsedImplicitly]
	public void StepLeft()
	{
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x2F41890", Offset = "0x2F40890", VA = "0x182F41890")]
	[UsedImplicitly]
	public void StepRight()
	{
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	[UsedImplicitly]
	public void StepLeftSnow()
	{
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	[UsedImplicitly]
	public void StepRightSnow()
	{
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	[UsedImplicitly]
	public void LandLight()
	{
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	[UsedImplicitly]
	public void LandHeavy()
	{
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00004188 File Offset: 0x00002388
	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x2F3FC10", Offset = "0x2F3EC10", VA = "0x182F3FC10")]
	private float CalculateSpeedParameter()
	{
		return default(float);
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x2F40A80", Offset = "0x2F3FA80", VA = "0x182F40A80")]
	private void PlayLandSfxIfRemote()
	{
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x1145D90", Offset = "0x1144D90", VA = "0x181145D90")]
	public void SetWeaponInfo(weaponInfo weaponInfo)
	{
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x2F40D70", Offset = "0x2F3FD70", VA = "0x182F40D70")]
	public void RegisterCollider(Collider collider, bool lowSwingOnly)
	{
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x2F41F00", Offset = "0x2F40F00", VA = "0x182F41F00")]
	public void UnRegisterCollider(Collider collider)
	{
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x2F429D0", Offset = "0x2F419D0", VA = "0x182F429D0", Slot = "296")]
	public void UpdateWetness(float wetnessCurrent)
	{
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x2F42B60", Offset = "0x2F41B60", VA = "0x182F42B60")]
	public animEventsManager()
	{
	}

	// Token: 0x0400060A RID: 1546
	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0x28")]
	public bool Remote;

	// Token: 0x0400060B RID: 1547
	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x30")]
	private Buoyancy buoyancy;

	// Token: 0x0400060C RID: 1548
	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x38")]
	private CoopUnderfootSurface coopUnderfoot;

	// Token: 0x0400060D RID: 1549
	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x40")]
	private Animator _animator;

	// Token: 0x0400060E RID: 1550
	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private simpleIkSolver armIK;

	// Token: 0x0400060F RID: 1551
	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x50")]
	public GameObject bowArrow;

	// Token: 0x04000610 RID: 1552
	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0x58")]
	public GameObject spearSpawn;

	// Token: 0x04000611 RID: 1553
	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0x60")]
	public GameObject spearSpawn_upgraded;

	// Token: 0x04000612 RID: 1554
	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0x68")]
	public Transform spearThrowPos;

	// Token: 0x04000613 RID: 1555
	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0x70")]
	public Transform spearThrowPos_upgraded;

	// Token: 0x04000614 RID: 1556
	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ammoBallHeld;

	// Token: 0x04000615 RID: 1557
	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0x80")]
	public float throwForce;

	// Token: 0x04000616 RID: 1558
	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0x84")]
	[ItemIdPicker]
	public int _spearId;

	// Token: 0x04000617 RID: 1559
	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x88")]
	[ItemIdPicker]
	public int _spearUpgradedId;

	// Token: 0x04000618 RID: 1560
	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x90")]
	public Transform hitTriggerTr;

	// Token: 0x04000619 RID: 1561
	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x98")]
	private List<Collider> _registeredWeaponColliders;

	// Token: 0x0400061A RID: 1562
	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0xA0")]
	private List<Collider> _lowSwingWeaponCollider;

	// Token: 0x0400061B RID: 1563
	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0xA8")]
	private weaponInfo _mainWeaponInfo;

	// Token: 0x0400061C RID: 1564
	[Token(Token = "0x400061C")]
	[FieldOffset(Offset = "0xB0")]
	private bool _weaponCollidersEnabled;

	// Token: 0x0400061D RID: 1565
	[Token(Token = "0x400061D")]
	[FieldOffset(Offset = "0xB1")]
	private bool _smashWeaponCollidersEnabled;

	// Token: 0x0400061E RID: 1566
	[Token(Token = "0x400061E")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Collider multiToolShovelCollider;

	// Token: 0x0400061F RID: 1567
	[Token(Token = "0x400061F")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Collider multiToolShovelFillCollider;

	// Token: 0x04000620 RID: 1568
	[Token(Token = "0x4000620")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GameObject _shovelMudTarget;

	// Token: 0x04000621 RID: 1569
	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0xD0")]
	public ParticleSystem leafFootParticle;

	// Token: 0x04000622 RID: 1570
	[Token(Token = "0x4000622")]
	[FieldOffset(Offset = "0xD8")]
	public ParticleSystem snowFootParticle;

	// Token: 0x04000623 RID: 1571
	[Token(Token = "0x4000623")]
	[FieldOffset(Offset = "0xE0")]
	public ParticleSystem dustFootParticle;

	// Token: 0x04000624 RID: 1572
	[Token(Token = "0x4000624")]
	[FieldOffset(Offset = "0xE8")]
	public ParticleSystem sandFootParticle;

	// Token: 0x04000625 RID: 1573
	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0xF0")]
	public ParticleSystem waterFootParticle;

	// Token: 0x04000626 RID: 1574
	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0xF8")]
	public ParticleSystem waterLegParticle;

	// Token: 0x04000627 RID: 1575
	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0x100")]
	public ParticleSystem waterArmParticle;

	// Token: 0x04000628 RID: 1576
	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x108")]
	public Transform leftFootSpawnPos;

	// Token: 0x04000629 RID: 1577
	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x110")]
	public Transform rightFootSpawnPos;

	// Token: 0x0400062A RID: 1578
	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x118")]
	public Transform leftArmSplashPos;

	// Token: 0x0400062B RID: 1579
	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x120")]
	public Transform rightArmSplashPos;

	// Token: 0x0400062C RID: 1580
	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x128")]
	public Collider underFootCollider;

	// Token: 0x0400062D RID: 1581
	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x130")]
	public ItemGroupEvent bowDrawEvent;

	// Token: 0x0400062E RID: 1582
	[Token(Token = "0x400062E")]
	[FieldOffset(Offset = "0x138")]
	public ItemGroupEvent stickSwooshEvent;

	// Token: 0x0400062F RID: 1583
	[Token(Token = "0x400062F")]
	[FieldOffset(Offset = "0x140")]
	public ItemGroupEvent axeSwooshEvent;

	// Token: 0x04000630 RID: 1584
	[Token(Token = "0x4000630")]
	[FieldOffset(Offset = "0x148")]
	public ItemGroupEvent rockSwooshEvent;

	// Token: 0x04000631 RID: 1585
	[Token(Token = "0x4000631")]
	[FieldOffset(Offset = "0x150")]
	public ItemGroupEvent spearSwooshEvent;

	// Token: 0x04000632 RID: 1586
	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0x158")]
	public ItemGroupEvent swordSwooshEvent;

	// Token: 0x04000633 RID: 1587
	[Token(Token = "0x4000633")]
	[FieldOffset(Offset = "0x160")]
	public ItemGroupEvent fireStickSwooshEvent;

	// Token: 0x04000634 RID: 1588
	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0x168")]
	private Dictionary<int, ItemGroupEvent> eventsByItemIdCache;

	// Token: 0x04000635 RID: 1589
	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0x170")]
	public string breatheInEvent;

	// Token: 0x04000636 RID: 1590
	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0x178")]
	public string breatheOutEvent;

	// Token: 0x04000637 RID: 1591
	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0x180")]
	public string fallEvent;

	// Token: 0x04000638 RID: 1592
	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x188")]
	public string pushSledEvent;

	// Token: 0x04000639 RID: 1593
	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0x190")]
	private EventInstance sledEvent;

	// Token: 0x0400063A RID: 1594
	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0x198")]
	private float snowStartHeight;

	// Token: 0x0400063B RID: 1595
	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0x19C")]
	private float snowFadeLength;

	// Token: 0x0400063C RID: 1596
	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x1A0")]
	private AnimatorStateInfo currState0;

	// Token: 0x0400063D RID: 1597
	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x1C4")]
	private AnimatorStateInfo currState2;

	// Token: 0x0400063E RID: 1598
	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x1E8")]
	private int raftIdleHash;

	// Token: 0x0400063F RID: 1599
	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x1EC")]
	private int raftPaddleHash;

	// Token: 0x04000640 RID: 1600
	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x1F0")]
	private Vector3 previousPosition;

	// Token: 0x04000641 RID: 1601
	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x200")]
	public Transform _weaponVelocityTr;

	// Token: 0x04000642 RID: 1602
	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x208")]
	private Vector3 _prevWepPos;

	// Token: 0x04000643 RID: 1603
	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0x214")]
	private Vector3 _prevWorldWepPos;

	// Token: 0x04000644 RID: 1604
	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x220")]
	private Vector3 _prevWristPos;

	// Token: 0x04000645 RID: 1605
	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x230")]
	private Vector3[] _startSwingPositions;

	// Token: 0x04000646 RID: 1606
	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x238")]
	private float _vrWeaponAttackWindow;

	// Token: 0x04000647 RID: 1607
	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x23C")]
	public float _vrEnableWeaponVelocity;

	// Token: 0x04000648 RID: 1608
	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x240")]
	public float minWristVelocity;

	// Token: 0x04000649 RID: 1609
	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x244")]
	public float _minArcDistance;

	// Token: 0x0400064A RID: 1610
	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0x248")]
	private Vector3 arcStartPosition;

	// Token: 0x0400064B RID: 1611
	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x254")]
	private float _enableWeaponTimer;

	// Token: 0x0400064C RID: 1612
	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x258")]
	private int _swingPosCounter;

	// Token: 0x0400064D RID: 1613
	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x25C")]
	private int fixedUpdateCount;

	// Token: 0x0400064E RID: 1614
	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x260")]
	[NonSerialized]
	public bool IsSledTurning;

	// Token: 0x04000650 RID: 1616
	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x0")]
	private static int idleToPushSledHash;

	// Token: 0x04000651 RID: 1617
	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x4")]
	private static int pushSledIdleHash;

	// Token: 0x04000652 RID: 1618
	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0x8")]
	private static int locomotionHash;

	// Token: 0x04000653 RID: 1619
	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x270")]
	public bool introCutScene;

	// Token: 0x04000654 RID: 1620
	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x274")]
	private float _wetnessCurrent;
}
