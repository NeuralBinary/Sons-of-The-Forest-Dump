using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using FMOD;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Cutscenes;
using Sons.Gameplay;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace TheForest
{
	// Token: 0x02000357 RID: 855
	[Token(Token = "0x2000357")]
	public class DebugConsole : MonoBehaviour
	{
		// Token: 0x06001559 RID: 5465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001559")]
		[Address(RVA = "0x3212210", Offset = "0x3210810", VA = "0x183212210")]
		private void _aiPause(string onoff)
		{
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x32122C0", Offset = "0x32108C0", VA = "0x1832122C0")]
		private void _aiShowDebugCamera(string onoff)
		{
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x3212370", Offset = "0x3210970", VA = "0x183212370")]
		private void _aiVerboseLog(string onoff)
		{
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x3212420", Offset = "0x3210A20", VA = "0x183212420")]
		private void _aiWorldStats(string onoff)
		{
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x32124D0", Offset = "0x3210AD0", VA = "0x1832124D0")]
		private void _aiPoolStats(string onoff)
		{
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x3212580", Offset = "0x3210B80", VA = "0x183212580")]
		private void _aiWorldEventStats(string onoff)
		{
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x3212630", Offset = "0x3210C30", VA = "0x183212630")]
		private void _aiZoneStats(string onoff)
		{
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x32126E0", Offset = "0x3210CE0", VA = "0x1832126E0")]
		private void _aiVillageClosest(string onoff)
		{
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x3212790", Offset = "0x3210D90", VA = "0x183212790")]
		private void _aiVailStats(string onoff)
		{
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001562")]
		[Address(RVA = "0x3212840", Offset = "0x3210E40", VA = "0x183212840")]
		private void _removeDead(string param)
		{
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001563")]
		[Address(RVA = "0x32128D0", Offset = "0x3210ED0", VA = "0x1832128D0")]
		private void _removeLiving(string param)
		{
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001564")]
		[Address(RVA = "0x3212970", Offset = "0x3210F70", VA = "0x183212970")]
		private void _damageDebug(string onoff)
		{
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001565")]
		[Address(RVA = "0x3212A20", Offset = "0x3211020", VA = "0x183212A20")]
		private void _aiJumpDebug(string onoff)
		{
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x3212AD0", Offset = "0x32110D0", VA = "0x183212AD0")]
		private void _aiGodMode(string onoff)
		{
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001567")]
		[Address(RVA = "0x3212B80", Offset = "0x3211180", VA = "0x183212B80")]
		private void _aiKnockdownDisable(string onoff)
		{
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x3212C30", Offset = "0x3211230", VA = "0x183212C30")]
		private void _characterLods(string onoff)
		{
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x3212CE0", Offset = "0x32112E0", VA = "0x183212CE0")]
		private void _aiDummy(string onoff)
		{
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x3212D90", Offset = "0x3211390", VA = "0x183212D90")]
		private void _aiGhostPlayer(string onoff)
		{
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x3212E40", Offset = "0x3211440", VA = "0x183212E40")]
		private void _aiForceStrafe(string onoff)
		{
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x3212EF0", Offset = "0x32114F0", VA = "0x183212EF0")]
		private void _aiShowPaths(string onoff)
		{
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x3212FA0", Offset = "0x32115A0", VA = "0x183212FA0")]
		private void _aiStructureLog(string onoff)
		{
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x3213050", Offset = "0x3211650", VA = "0x183213050")]
		private void _aiShowNavGraph(string fullParam)
		{
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x32132E0", Offset = "0x32118E0", VA = "0x1832132E0")]
		private void _aiDisable(string onoff)
		{
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x32133B0", Offset = "0x32119B0", VA = "0x1832133B0")]
		private void _animalsEnabled(string onoff)
		{
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x32134F0", Offset = "0x3211AF0", VA = "0x1832134F0")]
		private void _animalLimitMult(string param)
		{
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x32135C0", Offset = "0x3211BC0", VA = "0x1832135C0")]
		private void _aiAnimSpeed(string param)
		{
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x32136D0", Offset = "0x3211CD0", VA = "0x1832136D0")]
		private void _navGraphForceUpdate(string param)
		{
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x3213770", Offset = "0x3211D70", VA = "0x183213770")]
		private void _aiHelicopter(string onoff)
		{
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x32138A0", Offset = "0x3211EA0", VA = "0x1832138A0")]
		private void _aiRunWorldEvent(string param)
		{
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x3213B00", Offset = "0x3212100", VA = "0x183213B00")]
		private void _aiShowDebug(string param)
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x3213C70", Offset = "0x3212270", VA = "0x183213C70")]
		private void GetParamAndFilter(string fullParam, out string param, out string filter)
		{
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x3213E20", Offset = "0x3212420", VA = "0x183213E20")]
		private void _aiShowAnims(string paramString)
		{
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x32140F0", Offset = "0x32126F0", VA = "0x1832140F0")]
		private void UpdateShowOverlay(VailOverlayType overlayType, string paramString)
		{
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x32142D0", Offset = "0x32128D0", VA = "0x1832142D0")]
		private void _aiShowStats(string paramString)
		{
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x32142E0", Offset = "0x32128E0", VA = "0x1832142E0")]
		private void _aiShowSurvivalStats(string paramString)
		{
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x32142F0", Offset = "0x32128F0", VA = "0x1832142F0")]
		private void _aiShowHealth(string paramString)
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x3214300", Offset = "0x3212900", VA = "0x183214300")]
		private void _aiShowThoughts(string paramString)
		{
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x3214310", Offset = "0x3212910", VA = "0x183214310")]
		private void _aiShowPlayerInfluences(string paramString)
		{
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x3214320", Offset = "0x3212920", VA = "0x183214320")]
		private void _aiShowEventMemory(string paramString)
		{
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x3214330", Offset = "0x3212930", VA = "0x183214330")]
		private void _aiShowAnimTags(string paramString)
		{
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x3214340", Offset = "0x3212940", VA = "0x183214340")]
		private void _aiRadar(string paramString)
		{
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x32146A0", Offset = "0x3212CA0", VA = "0x1832146A0")]
		private void _virtualPlayers(string param)
		{
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x3214860", Offset = "0x3212E60", VA = "0x183214860")]
		private void _aiArmorLevel(string param)
		{
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x32149F0", Offset = "0x3212FF0", VA = "0x1832149F0")]
		private void _aiArmorTier(string param)
		{
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x3214BA0", Offset = "0x32131A0", VA = "0x183214BA0")]
		private void _aiAngerLevel(string param)
		{
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x3214D30", Offset = "0x3213330", VA = "0x183214D30")]
		private void _aiThought(string param)
		{
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x3214E00", Offset = "0x3213400", VA = "0x183214E00")]
		private void _aiThoughtNoCooldown(string onoff)
		{
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x3214EB0", Offset = "0x32134B0", VA = "0x183214EB0")]
		private void _aiMemoryAdjust(string param)
		{
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x32150C0", Offset = "0x32136C0", VA = "0x1832150C0")]
		private void _aiStatAdjust(string param)
		{
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x32152F0", Offset = "0x32138F0", VA = "0x1832152F0")]
		private void _aiTestSleep(string param)
		{
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x3215490", Offset = "0x3213A90", VA = "0x183215490")]
		private void _killRadius(string param)
		{
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x32157C0", Offset = "0x3213DC0", VA = "0x1832157C0")]
		private float GetFloatParam(string fullParam, int idx, float defValue = 0f)
		{
			return 0f;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x3215910", Offset = "0x3213F10", VA = "0x183215910")]
		private void _igniteRadius(string param)
		{
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x3215AB0", Offset = "0x32140B0", VA = "0x183215AB0")]
		private void _burnBodyRadius(string param)
		{
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x3215C50", Offset = "0x3214250", VA = "0x183215C50")]
		private void _dismemberRadius(string param)
		{
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x3215DF0", Offset = "0x32143F0", VA = "0x183215DF0")]
		private void _damageRadius(string param)
		{
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x3215FA0", Offset = "0x32145A0", VA = "0x183215FA0")]
		private void _addVirginia(string param)
		{
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x32162B0", Offset = "0x32148B0", VA = "0x1832162B0")]
		private void _virginiaGiveItem(int itemId)
		{
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x3216370", Offset = "0x3214970", VA = "0x183216370")]
		private void _virginiaGivePlayer(string itemType)
		{
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x32164E0", Offset = "0x3214AE0", VA = "0x1832164E0")]
		private void _virginiaSentiment(string param)
		{
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x3216610", Offset = "0x3214C10", VA = "0x183216610")]
		private void _virginiaVisit(string param)
		{
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x3216710", Offset = "0x3214D10", VA = "0x183216710")]
		private void _robbyCarry(string param)
		{
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x32167C0", Offset = "0x3214DC0", VA = "0x1832167C0")]
		private void _creepyVillage(string param)
		{
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x3216940", Offset = "0x3214F40", VA = "0x183216940")]
		public void OnShowStatsChanged()
		{
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x3216950", Offset = "0x3214F50", VA = "0x183216950")]
		private void _virginiaInCutscenes(string arg)
		{
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x3216A00", Offset = "0x3215000", VA = "0x183216A00")]
		private void _robbyInCutscenes(string arg)
		{
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x3216AB0", Offset = "0x32150B0", VA = "0x183216AB0")]
		private void _clearmidactionflag(object obj)
		{
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x3216B90", Offset = "0x3215190", VA = "0x183216B90")]
		private void _resetHeldAnim(string param)
		{
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x3216E80", Offset = "0x3215480", VA = "0x183216E80")]
		private void _forcePlayerExpression(string name)
		{
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x3216FE0", Offset = "0x32155E0", VA = "0x183216FE0")]
		private void _playerAnimParams(string arg)
		{
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x3217540", Offset = "0x3215B40", VA = "0x183217540")]
		private static void LogOutPlayerParameter(AnimatorControllerParameter param, Animator animator, StringBuilder sb)
		{
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x3217940", Offset = "0x3215F40", VA = "0x183217940")]
		private void _audioDebug(string onOff)
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x32179F0", Offset = "0x3215FF0", VA = "0x1832179F0")]
		private static void SetAudioDebug(bool value)
		{
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x3217BB0", Offset = "0x32161B0", VA = "0x183217BB0")]
		private void _clearAudioParameters(string audioParamPattern)
		{
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x3217C10", Offset = "0x3216210", VA = "0x183217C10")]
		private void _audioParameter(string audioParamPattern)
		{
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x3217FE0", Offset = "0x32165E0", VA = "0x183217FE0")]
		private bool EventMatchesPattern(string eventName, string audioEventPattern)
		{
			return default(bool);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x3218100", Offset = "0x3216700", VA = "0x183218100")]
		private void _audio2dTest(string arg)
		{
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x32181B0", Offset = "0x32167B0", VA = "0x1832181B0")]
		private void Set2dAudioTest(bool value)
		{
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x3218620", Offset = "0x3216C20", VA = "0x183218620")]
		private void _audioPlayEvent(string audioEventPattern)
		{
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x3218870", Offset = "0x3216E70", VA = "0x183218870")]
		private void _audioDescription(string audioEventPattern)
		{
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x3218D70", Offset = "0x3217370", VA = "0x183218D70")]
		private void PlayAudioEvent(string eachEvent)
		{
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x32194E0", Offset = "0x3217AE0", VA = "0x1832194E0")]
		private void _freecamera(string onoff)
		{
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015AB")]
		[Address(RVA = "0x3219FE0", Offset = "0x32185E0", VA = "0x183219FE0")]
		private void _dynamicResCameraDebug(string onoff)
		{
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x321A090", Offset = "0x3218690", VA = "0x18321A090")]
		private void _playerDebugCamera(string onoff)
		{
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x321A310", Offset = "0x3218910", VA = "0x18321A310")]
		private void _cameraDlss(string onOff)
		{
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x321A710", Offset = "0x3218D10", VA = "0x18321A710")]
		private void _cameraFov(string fov)
		{
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x321AA00", Offset = "0x3219000", VA = "0x18321AA00")]
		private bool HandleInput()
		{
			return default(bool);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x321AAB0", Offset = "0x32190B0", VA = "0x18321AAB0")]
		private void SanitizeCommandInput()
		{
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000070B0 File Offset: 0x000052B0
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x321AD40", Offset = "0x3219340", VA = "0x18321AD40")]
		private bool HandleConsoleKeys()
		{
			return default(bool);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x321B2B0", Offset = "0x32198B0", VA = "0x18321B2B0")]
		private bool CheckDebugInputs()
		{
			return default(bool);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B3")]
		[Address(RVA = "0x321B4B0", Offset = "0x3219AB0", VA = "0x18321B4B0")]
		private void CommandAutoComplete()
		{
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x321B680", Offset = "0x3219C80", VA = "0x18321B680")]
		private void CommandHistoryForward()
		{
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x321B740", Offset = "0x3219D40", VA = "0x18321B740")]
		private void CommandHistoryBack()
		{
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x321B820", Offset = "0x3219E20", VA = "0x18321B820")]
		private string FindAutoComplete(string consoleInput)
		{
			return null;
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B7")]
		public static string FindAutoComplete<T>(string prefix, Dictionary<string, T> dynamicCommands)
		{
			return null;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x321B910", Offset = "0x3219F10", VA = "0x18321B910")]
		private static string FindAutoComplete(string prefix, List<string> searchList)
		{
			return null;
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x321BAC0", Offset = "0x321A0C0", VA = "0x18321BAC0")]
		private void BuildCommandShortList()
		{
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x321C5E0", Offset = "0x321ABE0", VA = "0x18321C5E0")]
		private void Awake()
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x321DC00", Offset = "0x321C200", VA = "0x18321DC00")]
		private void OnEnable()
		{
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x321DC90", Offset = "0x321C290", VA = "0x18321DC90")]
		private void OnDisable()
		{
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x321DD70", Offset = "0x321C370", VA = "0x18321DD70")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x321DE50", Offset = "0x321C450", VA = "0x18321DE50")]
		private void OnDestroy()
		{
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x321E2C0", Offset = "0x321C8C0", VA = "0x18321E2C0")]
		private void Update()
		{
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x321E6E0", Offset = "0x321CCE0", VA = "0x18321E6E0")]
		private void OnGUI()
		{
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x321F310", Offset = "0x321D910", VA = "0x18321F310")]
		private void DrawFramerate()
		{
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x321F5C0", Offset = "0x321DBC0", VA = "0x18321F5C0")]
		private void DrawConsole(Color defaultColor)
		{
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x32202C0", Offset = "0x321E8C0", VA = "0x1832202C0")]
		private void DrawOverlay()
		{
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x3223EF0", Offset = "0x32224F0", VA = "0x183223EF0")]
		private string GetDynamicResString()
		{
			return null;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x32240A0", Offset = "0x32226A0", VA = "0x1832240A0")]
		private string GetDynamicResScalarString()
		{
			return null;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x3224160", Offset = "0x3222760", VA = "0x183224160")]
		private void ShowLog()
		{
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x3224340", Offset = "0x3222940", VA = "0x183224340")]
		private void RefreshLogMessages()
		{
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x3224A20", Offset = "0x3223020", VA = "0x183224A20")]
		private void ShowLegacyLog()
		{
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x3225230", Offset = "0x3223830", VA = "0x183225230")]
		private Color GetTextColor(Color defaultColor, LogType logType)
		{
			return default(Color);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x3225290", Offset = "0x3223890", VA = "0x183225290")]
		private static string GetTimeString()
		{
			return null;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x3225600", Offset = "0x3223C00", VA = "0x183225600")]
		private static string ToMbString(ulong bytesValue)
		{
			return null;
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x32256F0", Offset = "0x3223CF0", VA = "0x1832256F0")]
		private static string ToMbString(long bytesValue)
		{
			return null;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x32257C0", Offset = "0x3223DC0", VA = "0x1832257C0")]
		public static DebugConsole GetInstance()
		{
			return null;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x3225810", Offset = "0x3223E10", VA = "0x183225810")]
		private void ToggleConsole()
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x3225820", Offset = "0x3223E20", VA = "0x183225820")]
		public void SendCommand(string command)
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x32258A0", Offset = "0x3223EA0", VA = "0x1832258A0")]
		private void FinalizeConsoleInput()
		{
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x32258D0", Offset = "0x3223ED0", VA = "0x1832258D0")]
		private void ShowConsole(bool showConsole)
		{
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x3225D90", Offset = "0x3224390", VA = "0x183225D90")]
		private void ToggleOverlay()
		{
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x3225E00", Offset = "0x3224400", VA = "0x183225E00")]
		private void TogglePlayerStats()
		{
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x3225E20", Offset = "0x3224420", VA = "0x183225E20")]
		private void ToggleVailStats()
		{
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x3226010", Offset = "0x3224610", VA = "0x183226010")]
		private void _spawnedObjectStats(string onoff)
		{
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x32260C0", Offset = "0x32246C0", VA = "0x1832260C0")]
		private void ToggleGamePadWheel()
		{
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x3226260", Offset = "0x3224860", VA = "0x183226260")]
		private void ShowGamepadWheel()
		{
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x3226CA0", Offset = "0x32252A0", VA = "0x183226CA0")]
		private void CheckDisplayState()
		{
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x3227250", Offset = "0x3225850", VA = "0x183227250")]
		private IEnumerator SilentInput()
		{
			return null;
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x32272E0", Offset = "0x32258E0", VA = "0x1832272E0")]
		public static void AddCounter(Type t)
		{
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x3227570", Offset = "0x3225B70", VA = "0x183227570")]
		public static void RemoveCounter(Type t)
		{
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x32277C0", Offset = "0x3225DC0", VA = "0x1832277C0")]
		private void CheckAmount(Type t, int amount)
		{
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x3227A30", Offset = "0x3226030", VA = "0x183227A30")]
		public void LogCallback(string condition, string stackTrace, LogType type)
		{
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x3227EB0", Offset = "0x32264B0", VA = "0x183227EB0")]
		private IEnumerator Report(string message)
		{
			return null;
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x3227FB0", Offset = "0x32265B0", VA = "0x183227FB0")]
		public UnityWebRequest CreateApiPostRequest(string actionUrl, [Optional] string body)
		{
			return null;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x32280D0", Offset = "0x32266D0", VA = "0x1832280D0")]
		public bool IsAlphaNum(string s)
		{
			return default(bool);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x3228110", Offset = "0x3226710", VA = "0x183228110")]
		public void HandleConsoleInput(string consoleInput)
		{
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x3228BF0", Offset = "0x32271F0", VA = "0x183228BF0")]
		private void LogCommandInfo(string message)
		{
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x3228D50", Offset = "0x3227350", VA = "0x183228D50")]
		private void LogCommandRunning(string message)
		{
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x3228EB0", Offset = "0x32274B0", VA = "0x183228EB0")]
		public static void LogCommandFailed(string message)
		{
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x3229010", Offset = "0x3227610", VA = "0x183229010")]
		public static void EventRegistryCleared(object eventParameter)
		{
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x3229110", Offset = "0x3227710", VA = "0x183229110")]
		public static void LogBoltClients(string arg)
		{
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x32295B0", Offset = "0x3227BB0", VA = "0x1832295B0")]
		public static void CheatsAllowedSet(object eventParameter)
		{
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x3229840", Offset = "0x3227E40", VA = "0x183229840")]
		public static void ApplyCommandBool(string onoff, Action<bool> applyAction, string commandString)
		{
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x32299D0", Offset = "0x3227FD0", VA = "0x1832299D0")]
		public static void ApplyCommandFloat(string floatString, Action<float> applyAction, Action<bool> onOffAction, string commandString)
		{
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x3229C20", Offset = "0x3228220", VA = "0x183229C20")]
		public static void ApplyCommandFloat(string floatString, Action<float> applyAction, string commandString)
		{
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x3229D90", Offset = "0x3228390", VA = "0x183229D90")]
		private static bool GetOnOffSet(string onoff, out bool onSet, out bool offSet, bool include0and1 = true)
		{
			return default(bool);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x322A1D0", Offset = "0x32287D0", VA = "0x18322A1D0")]
		private static void ApplyCommandBool(bool onSet, Action<bool> applyAction, string commandString)
		{
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x322A2A0", Offset = "0x32288A0", VA = "0x18322A2A0")]
		private static void ApplyCommandFloat(float floatValue, Action<float> applyAction, string commandString)
		{
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x322A370", Offset = "0x3228970", VA = "0x18322A370")]
		private void _logging(string onoff)
		{
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x322A4F0", Offset = "0x3228AF0", VA = "0x18322A4F0")]
		private void _logShowWarnings(string onOff)
		{
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x322A5A0", Offset = "0x3228BA0", VA = "0x18322A5A0")]
		private void _logShowErrors(string onOff)
		{
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x322A650", Offset = "0x3228C50", VA = "0x18322A650")]
		private void _logShowInfo(string onOff)
		{
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x322A700", Offset = "0x3228D00", VA = "0x18322A700")]
		private void _logShowNone(string onOff)
		{
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x322A7B0", Offset = "0x3228DB0", VA = "0x18322A7B0")]
		private void _help(object o)
		{
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x322AA50", Offset = "0x3229050", VA = "0x18322AA50")]
		private void _clear(object o)
		{
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x3225E00", Offset = "0x3224400", VA = "0x183225E00")]
		private void _togglePlayerStats(object o)
		{
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x3225D90", Offset = "0x3224390", VA = "0x183225D90")]
		private void _toggleOverlay(object o)
		{
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x322AAE0", Offset = "0x32290E0", VA = "0x18322AAE0")]
		private void _playerVisibility(string onoff)
		{
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x31A3F50", Offset = "0x31A2550", VA = "0x1831A3F50")]
		private void SetShowPlayerVisibility(bool value)
		{
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x322AB90", Offset = "0x3229190", VA = "0x18322AB90")]
		private void _showFps(string onoff)
		{
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x31A3F40", Offset = "0x31A2540", VA = "0x1831A3F40")]
		private void SetShowFrameRate(bool value)
		{
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x322AC40", Offset = "0x3229240", VA = "0x18322AC40")]
		private void _toggleFPSDisplay(string val)
		{
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x322AC50", Offset = "0x3229250", VA = "0x18322AC50")]
		private void _reporterrorsnow(string message)
		{
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x322B000", Offset = "0x3229600", VA = "0x18322B000")]
		private void _reportwarningsnow(string message)
		{
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x322B3B0", Offset = "0x32299B0", VA = "0x18322B3B0")]
		private void _reportlogsnow(string message)
		{
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x322B760", Offset = "0x3229D60", VA = "0x18322B760")]
		private void _count(string name)
		{
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x322B950", Offset = "0x3229F50", VA = "0x18322B950")]
		private void _counttag(string name)
		{
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x322BB00", Offset = "0x322A100", VA = "0x18322BB00")]
		private void _enableCheats(string toggle)
		{
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x322BBB0", Offset = "0x322A1B0", VA = "0x18322BBB0")]
		private static void SetCheatsAllowed(bool toggle)
		{
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x322BC00", Offset = "0x322A200", VA = "0x18322BC00")]
		private void _showProjectileTrails(string onOff)
		{
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x322BD90", Offset = "0x322A390", VA = "0x18322BD90")]
		private void _enablego(string name)
		{
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x322C050", Offset = "0x322A650", VA = "0x18322C050")]
		private static GameObject FindTest(string name)
		{
			return null;
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x322C0B0", Offset = "0x322A6B0", VA = "0x18322C0B0")]
		private void _spawnRenderSpheres(string onoff)
		{
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x322C600", Offset = "0x322AC00", VA = "0x18322C600")]
		private void _renderSpheres(string onoff)
		{
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x322C6B0", Offset = "0x322ACB0", VA = "0x18322C6B0")]
		private void _areaShadow(string onoff)
		{
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x322C760", Offset = "0x322AD60", VA = "0x18322C760")]
		private void ShowDebugRenderSpheres(bool activeValue)
		{
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x322C860", Offset = "0x322AE60", VA = "0x18322C860")]
		private void ShowDebugAreaShadow(bool activeValue)
		{
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x322C960", Offset = "0x322AF60", VA = "0x18322C960")]
		private void _disableScene(string name)
		{
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160C")]
		[Address(RVA = "0x322CDD0", Offset = "0x322B3D0", VA = "0x18322CDD0")]
		private void _enableScene(string name)
		{
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x322D240", Offset = "0x322B840", VA = "0x18322D240")]
		private void _destroyWildcard(string wildcard)
		{
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160E")]
		[Address(RVA = "0x322D4B0", Offset = "0x322BAB0", VA = "0x18322D4B0")]
		private void _disableGoWildcard(string wildcard)
		{
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160F")]
		[Address(RVA = "0x322D790", Offset = "0x322BD90", VA = "0x18322D790")]
		private void _disablego(string name)
		{
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x322D9D0", Offset = "0x322BFD0", VA = "0x18322D9D0")]
		private void _disablecomponent(string name)
		{
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x322E490", Offset = "0x322CA90", VA = "0x18322E490")]
		private void _enablecomponent(string name)
		{
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00007128 File Offset: 0x00005328
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x322EF50", Offset = "0x322D550", VA = "0x18322EF50")]
		private static bool FindComponent(string name, int lastIndex, out string componentName, out string objectName, out GameObject go)
		{
			return default(bool);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x322F1A0", Offset = "0x322D7A0", VA = "0x18322F1A0")]
		private static bool SetComponentEnabled(GameObject go, string componentName, bool componentEnabled)
		{
			return default(bool);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x322F380", Offset = "0x322D980", VA = "0x18322F380")]
		private void _togglego(string name)
		{
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001615")]
		[Address(RVA = "0x322F780", Offset = "0x322DD80", VA = "0x18322F780")]
		private void _destroy(string name)
		{
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001616")]
		[Address(RVA = "0x322F9B0", Offset = "0x322DFB0", VA = "0x18322F9B0")]
		private void _listitems(object o)
		{
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x3230010", Offset = "0x322E610", VA = "0x183230010")]
		private void _setSpeakerMode(string mode)
		{
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x3230680", Offset = "0x322EC80", VA = "0x183230680")]
		private static void SetSpeakerMode(SPEAKERMODE newSpeakerMode)
		{
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x32307C0", Offset = "0x322EDC0", VA = "0x1832307C0")]
		private void _listitemswithtags(object o)
		{
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161A")]
		[Address(RVA = "0x3230CF0", Offset = "0x322F2F0", VA = "0x183230CF0")]
		private void _additem(string nameOrId)
		{
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161B")]
		[Address(RVA = "0x3231060", Offset = "0x322F660", VA = "0x183231060")]
		private void _removeitem(string nameOrId)
		{
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161C")]
		[Address(RVA = "0x3231490", Offset = "0x322FA90", VA = "0x183231490")]
		private void _additemswithtag(string tag)
		{
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x3231880", Offset = "0x322FE80", VA = "0x183231880")]
		private void _spawnpickup(string nameOrId)
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x3231C50", Offset = "0x3230250", VA = "0x183231C50")]
		private void _setinventorypercent(string arg)
		{
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x3231F60", Offset = "0x3230560", VA = "0x183231F60")]
		private void _addAllItems(object o)
		{
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x3232330", Offset = "0x3230930", VA = "0x183232330")]
		private void _removeAllItems(object o)
		{
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x32325D0", Offset = "0x3230BD0", VA = "0x1832325D0")]
		private void _addAllStoryItems(object o)
		{
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001622")]
		[Address(RVA = "0x3232820", Offset = "0x3230E20", VA = "0x183232820")]
		private void _removeAllStoryItems(object o)
		{
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x3232A90", Offset = "0x3231090", VA = "0x183232A90")]
		private void _veganmode(string onoff)
		{
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x3232C70", Offset = "0x3231270", VA = "0x183232C70")]
		private void _loghack(string onoff)
		{
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x3232FB0", Offset = "0x32315B0", VA = "0x183232FB0")]
		private void _stonehack(string onoff)
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x32332F0", Offset = "0x32318F0", VA = "0x1832332F0")]
		private void _energyhack(string onoff)
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x32334B0", Offset = "0x3231AB0", VA = "0x1832334B0")]
		private void _ammohack(string onoff)
		{
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x3233670", Offset = "0x3231C70", VA = "0x183233670")]
		public void _godmode(string onoff)
		{
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x3233920", Offset = "0x3231F20", VA = "0x183233920")]
		private void _buildhack(string onoff)
		{
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x3233B90", Offset = "0x3232190", VA = "0x183233B90")]
		private void _survival(string onoff)
		{
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x3233D50", Offset = "0x3232350", VA = "0x183233D50")]
		private void _workscheduler(string trycatch)
		{
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x3233EC0", Offset = "0x32324C0", VA = "0x183233EC0")]
		private void _timescale(string scaleStr)
		{
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x3234080", Offset = "0x3232680", VA = "0x183234080")]
		public void _lockTimeOfDay(string value)
		{
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x3234180", Offset = "0x3232780", VA = "0x183234180")]
		private void _jumpTimeOfDay(string value)
		{
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x32343D0", Offset = "0x32329D0", VA = "0x1832343D0")]
		private void _setTimeOfDay(string value)
		{
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x3234480", Offset = "0x3232A80", VA = "0x183234480")]
		private bool TrySetTimeOfDay(string value)
		{
			return default(bool);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x3234540", Offset = "0x3232B40", VA = "0x183234540")]
		private void _setGameTimeSpeed(string speedStr)
		{
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x3234720", Offset = "0x3232D20", VA = "0x183234720")]
		private void _heallocalplayer(string amountString)
		{
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x3234AA0", Offset = "0x32330A0", VA = "0x183234AA0")]
		private void _hitlocalplayer(string damageStr)
		{
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x3234D20", Offset = "0x3233320", VA = "0x183234D20")]
		private static void HitLocalPlayer(int damage)
		{
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x3234DC0", Offset = "0x32333C0", VA = "0x183234DC0")]
		private void _knockdownLocalPlayer(string param)
		{
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x3234FE0", Offset = "0x32335E0", VA = "0x183234FE0")]
		private static void KnockDownLocalPlayer(int damage)
		{
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x3235080", Offset = "0x3233680", VA = "0x183235080")]
		private void _playDeathCutscene(string args)
		{
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x32353E0", Offset = "0x32339E0", VA = "0x1832353E0")]
		private void _listDeathMarkers(string args)
		{
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001639")]
		[Address(RVA = "0x3235A70", Offset = "0x3234070", VA = "0x183235A70")]
		private void _playDeathMarkerIndex(string args)
		{
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x3236330", Offset = "0x3234930", VA = "0x183236330")]
		private void _playDeathMarker(string args)
		{
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x3236610", Offset = "0x3234C10", VA = "0x183236610")]
		private void PlayDrownMarker(WaterDrownMarker drownMarker)
		{
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x3236890", Offset = "0x3234E90", VA = "0x183236890")]
		private void PlayDeathMarker(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x3236A60", Offset = "0x3235060", VA = "0x183236A60")]
		private void PlayDeathFinal()
		{
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x3236C10", Offset = "0x3235210", VA = "0x183236C10")]
		private void _killlocalplayer(object o)
		{
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x3236E00", Offset = "0x3235400", VA = "0x183236E00")]
		private void _deathCount(string value)
		{
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x3236FF0", Offset = "0x32355F0", VA = "0x183236FF0")]
		private void _playGameOver(object o)
		{
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x32371B0", Offset = "0x32357B0", VA = "0x1832371B0")]
		private void _revivelocalplayer(object o)
		{
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001642")]
		[Address(RVA = "0x32373C0", Offset = "0x32359C0", VA = "0x1832373C0")]
		private void _setExitedEndGame(string param)
		{
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x3237570", Offset = "0x3235B70", VA = "0x183237570")]
		private void _addAllBookPages(string arg)
		{
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x32375F0", Offset = "0x3235BF0", VA = "0x1832375F0")]
		private void _regenhealth(string arg)
		{
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x3237710", Offset = "0x3235D10", VA = "0x183237710")]
		private void _setstat(string arg)
		{
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x3238380", Offset = "0x3236980", VA = "0x183238380")]
		private void _getGameMode(string arg)
		{
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x3238490", Offset = "0x3236A90", VA = "0x183238490")]
		private void _setGameMode(string arg)
		{
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x3238700", Offset = "0x3236D00", VA = "0x183238700")]
		private void _setDifficultyMode(string arg)
		{
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x3238A10", Offset = "0x3237010", VA = "0x183238A10")]
		private void _setPlayerRace(string inputString)
		{
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x3238C70", Offset = "0x3237270", VA = "0x183238C70")]
		private void _follow(string arg)
		{
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x3238F00", Offset = "0x3237500", VA = "0x183238F00")]
		private void _followStop(string arg)
		{
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x3239040", Offset = "0x3237640", VA = "0x183239040")]
		private static void BuildGotoId(string arg, Vector3 position)
		{
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x32391A0", Offset = "0x32377A0", VA = "0x1832391A0")]
		private void _gotoCoords(string arg)
		{
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x32393F0", Offset = "0x32379F0", VA = "0x1832393F0")]
		private void _gotoforce(string arg)
		{
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x3239920", Offset = "0x3237F20", VA = "0x183239920")]
		private void _listObjects(string arg)
		{
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x3239A20", Offset = "0x3238020", VA = "0x183239A20")]
		private void _goto(string arg)
		{
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x3239FF0", Offset = "0x32385F0", VA = "0x183239FF0")]
		private void GotoTarget(GameObject target)
		{
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x323A3C0", Offset = "0x32389C0", VA = "0x18323A3C0")]
		private static bool CheckForGotoPos(GameObject target, int layerMask, out RaycastHit info)
		{
			return default(bool);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x323A7B0", Offset = "0x3238DB0", VA = "0x18323A7B0")]
		private void GotoPosition(Vector3 targetPos)
		{
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x323A950", Offset = "0x3238F50", VA = "0x18323A950")]
		private static GameObject FindObjectAdvanced(string arg, StringComparison comparisonType = StringComparison.InvariantCultureIgnoreCase, bool inactive = false)
		{
			return null;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00007188 File Offset: 0x00005388
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x323ACE0", Offset = "0x32392E0", VA = "0x18323ACE0")]
		private static bool FindAllObjects(string arg, out List<GameObject> allGameObjects, StringComparison comparisonType = StringComparison.InvariantCultureIgnoreCase, bool inactive = false)
		{
			return default(bool);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000071A0 File Offset: 0x000053A0
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x323B0E0", Offset = "0x32396E0", VA = "0x18323B0E0")]
		private static bool MatchGameObjectName(string arg, GameObject eachGo, StringComparison comparisonType)
		{
			return default(bool);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x323B210", Offset = "0x3239810", VA = "0x18323B210")]
		private static GameObject FindObjectIgnoreCase(string arg, bool inactive = false)
		{
			return null;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001658")]
		[Address(RVA = "0x323B5F0", Offset = "0x3239BF0", VA = "0x18323B5F0")]
		private void _gototag(string arg)
		{
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001659")]
		[Address(RVA = "0x323B7D0", Offset = "0x3239DD0", VA = "0x18323B7D0")]
		private void _sendMessageTo(string arg)
		{
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x323BD50", Offset = "0x323A350", VA = "0x18323BD50")]
		private void _profilersnapshot(object arg)
		{
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x323C4B0", Offset = "0x323AAB0", VA = "0x18323C4B0")]
		private void _profilersample(string onoff)
		{
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x323CC40", Offset = "0x323B240", VA = "0x18323CC40")]
		private void _unloadUnusedAssets(object o)
		{
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165D")]
		[Address(RVA = "0x323CCA0", Offset = "0x323B2A0", VA = "0x18323CCA0")]
		private void _filteraudio(string filter)
		{
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x120B650", Offset = "0x1209C50", VA = "0x18120B650")]
		private void setLastLocalTarget(Transform tr)
		{
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x323D000", Offset = "0x323B600", VA = "0x18323D000")]
		private void _refreshEntities(string val)
		{
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x323D1D0", Offset = "0x323B7D0", VA = "0x18323D1D0")]
		private void _listActiveEntities(string val)
		{
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001661")]
		[Address(RVA = "0x323D6A0", Offset = "0x323BCA0", VA = "0x18323D6A0")]
		private void _checkFrozenEntities(string onoff)
		{
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x323D990", Offset = "0x323BF90", VA = "0x18323D990")]
		private void _checkAttachedEntities(string onoff)
		{
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x323DC20", Offset = "0x323C220", VA = "0x18323DC20")]
		private void _greebledRocksCollision(string onoff)
		{
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001664")]
		[Address(RVA = "0x323E1B0", Offset = "0x323C7B0", VA = "0x18323E1B0")]
		private void _speedyrun(string onoff)
		{
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001665")]
		[Address(RVA = "0x323E4B0", Offset = "0x323CAB0", VA = "0x18323E4B0")]
		private void SetSpeedyRun(bool enable, float multiplier)
		{
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001666")]
		[Address(RVA = "0x323E590", Offset = "0x323CB90", VA = "0x18323E590")]
		private void _superJump(string onoff)
		{
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001667")]
		[Address(RVA = "0x323E790", Offset = "0x323CD90", VA = "0x18323E790")]
		private void _vrFps(string onoff)
		{
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x323E870", Offset = "0x323CE70", VA = "0x18323E870")]
		private void _checkExitMenu(string onoff)
		{
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001669")]
		[Address(RVA = "0x323E9A0", Offset = "0x323CFA0", VA = "0x18323E9A0")]
		private void _setWindIntensity(string val)
		{
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166A")]
		[Address(RVA = "0x323EEA0", Offset = "0x323D4A0", VA = "0x18323EEA0")]
		private void _resetInputAxes()
		{
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166B")]
		[Address(RVA = "0x323EEF0", Offset = "0x323D4F0", VA = "0x18323EEF0")]
		private void _terrainPixelError(string val)
		{
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166C")]
		[Address(RVA = "0x323F120", Offset = "0x323D720", VA = "0x18323F120")]
		private void _toggleVSync(string val)
		{
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166D")]
		[Address(RVA = "0x323F270", Offset = "0x323D870", VA = "0x18323F270")]
		private void _toggleOcclusionCulling(string val)
		{
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166E")]
		[Address(RVA = "0x323F4C0", Offset = "0x323DAC0", VA = "0x18323F4C0")]
		private void _terrainRenderSimple(string onoff)
		{
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x323F9D0", Offset = "0x323DFD0", VA = "0x18323F9D0")]
		private void _terrainRender(string onoff)
		{
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x323FD40", Offset = "0x323E340", VA = "0x18323FD40")]
		private void _targetFrameRate(string rate)
		{
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x323FDB0", Offset = "0x323E3B0", VA = "0x18323FDB0")]
		private void _invisible(string onoff)
		{
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001672")]
		[Address(RVA = "0x3240160", Offset = "0x323E760", VA = "0x183240160")]
		private void _playernetanimator(string onoff)
		{
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001673")]
		[Address(RVA = "0x3240680", Offset = "0x323EC80", VA = "0x183240680")]
		private void _capsulemode(string onoff)
		{
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x3240E40", Offset = "0x323F440", VA = "0x183240E40")]
		public void SetBlockConsole(bool block)
		{
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x3240E50", Offset = "0x323F450", VA = "0x183240E50")]
		private void _netAnimator(string onoff)
		{
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x32412B0", Offset = "0x323F8B0", VA = "0x1832412B0")]
		private void _netSkinnedBones(string onoff)
		{
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001677")]
		[Address(RVA = "0x3241660", Offset = "0x323FC60", VA = "0x183241660")]
		private void _netSpawnPlayer(string onoff)
		{
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001678")]
		[Address(RVA = "0x3241980", Offset = "0x323FF80", VA = "0x183241980")]
		private void _astar(string onoff)
		{
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001679")]
		[Address(RVA = "0x3241D00", Offset = "0x3240300", VA = "0x183241D00")]
		private void _useRigidBodyRotation(string onoff)
		{
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167A")]
		[Address(RVA = "0x3241EE0", Offset = "0x32404E0", VA = "0x183241EE0")]
		private void _setCurrentDay(string num)
		{
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x32423D0", Offset = "0x32409D0", VA = "0x1832423D0")]
		private void _forceCloud(string profile)
		{
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167C")]
		[Address(RVA = "0x32426A0", Offset = "0x3240CA0", VA = "0x1832426A0")]
		private void _forceCloudProfile(string profile)
		{
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167D")]
		[Address(RVA = "0x3242A40", Offset = "0x3241040", VA = "0x183242A40")]
		private void _cloudEnable(string onOff)
		{
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167E")]
		[Address(RVA = "0x3242BD0", Offset = "0x32411D0", VA = "0x183242BD0")]
		private void _cloudShadowsEnable(string onOff)
		{
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167F")]
		[Address(RVA = "0x3242D60", Offset = "0x3241360", VA = "0x183242D60")]
		private void _cloudFactor(string coverAmount)
		{
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x3242EF0", Offset = "0x32414F0", VA = "0x183242EF0")]
		private void _unlockSeason(string arg)
		{
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x3242F80", Offset = "0x3241580", VA = "0x183242F80")]
		private void _season(string arg)
		{
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001682")]
		[Address(RVA = "0x3243280", Offset = "0x3241880", VA = "0x183243280")]
		private void _forcerain(string arg)
		{
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x6001683")]
		[Address(RVA = "0x3243890", Offset = "0x3241E90", VA = "0x183243890")]
		private static bool HasMatch(string arg, string[] offStrings)
		{
			return default(bool);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001684")]
		[Address(RVA = "0x32439A0", Offset = "0x3241FA0", VA = "0x1832439A0")]
		private void _inspectgo(string name)
		{
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001685")]
		[Address(RVA = "0x3243FD0", Offset = "0x32425D0", VA = "0x183243FD0")]
		private void _loadDebugConsoleMod(string filename)
		{
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001686")]
		[Address(RVA = "0x3244130", Offset = "0x3242730", VA = "0x183244130")]
		private void _getlayerculldistance(string args)
		{
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001687")]
		[Address(RVA = "0x3244490", Offset = "0x3242A90", VA = "0x183244490")]
		private void _setlayerculldistance(string args)
		{
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x3244810", Offset = "0x3242E10", VA = "0x183244810")]
		private void _showworldposfor(string componentName)
		{
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001689")]
		[Address(RVA = "0x3244C50", Offset = "0x3243250", VA = "0x183244C50")]
		private void _hideworldposfor(string componentName)
		{
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168A")]
		[Address(RVA = "0x3245080", Offset = "0x3243680", VA = "0x183245080")]
		private void _slapchop(string onoff)
		{
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168B")]
		[Address(RVA = "0x32451E0", Offset = "0x32437E0", VA = "0x1832451E0")]
		private void _debugPlayerMelee(string param)
		{
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168C")]
		[Address(RVA = "0x3245330", Offset = "0x3243930", VA = "0x183245330")]
		private void _debugPlayerHitLog(string onoff)
		{
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168D")]
		[Address(RVA = "0x32453E0", Offset = "0x32439E0", VA = "0x1832453E0")]
		private void _clearallsettings(object arg)
		{
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168E")]
		[Address(RVA = "0x3245570", Offset = "0x3243B70", VA = "0x183245570")]
		private void _testeventmask(object arg)
		{
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168F")]
		[Address(RVA = "0x3245720", Offset = "0x3243D20", VA = "0x183245720")]
		private void _dumplobbyinfo(object arg)
		{
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001690")]
		[Address(RVA = "0x3245980", Offset = "0x3243F80", VA = "0x183245980")]
		private void _gccollect(object o)
		{
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001691")]
		[Address(RVA = "0x32459E0", Offset = "0x3243FE0", VA = "0x1832459E0")]
		private void _logTextures(string intervalArg)
		{
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001692")]
		[Address(RVA = "0x3245E10", Offset = "0x3244410", VA = "0x183245E10")]
		private void _addmemory(string amount)
		{
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001693")]
		[Address(RVA = "0x3245EC0", Offset = "0x32444C0", VA = "0x183245EC0")]
		private void _diagRenderers(string param)
		{
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001694")]
		[Address(RVA = "0x32465B0", Offset = "0x3244BB0", VA = "0x1832465B0")]
		private void _allowAsync(string onoff)
		{
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001695")]
		[Address(RVA = "0x3246700", Offset = "0x3244D00", VA = "0x183246700")]
		private void _footstepDebug(string param)
		{
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001696")]
		[Address(RVA = "0x3246760", Offset = "0x3244D60", VA = "0x183246760")]
		private void _buildermode(string onoff)
		{
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001697")]
		[Address(RVA = "0x3246940", Offset = "0x3244F40", VA = "0x183246940")]
		private void _trailer3(object o)
		{
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001698")]
		[Address(RVA = "0x32469C0", Offset = "0x3244FC0", VA = "0x1832469C0")]
		private void _toggleWorkScheduler(string param)
		{
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001699")]
		[Address(RVA = "0x3246CD0", Offset = "0x32452D0", VA = "0x183246CD0")]
		private void _wsscaling(string onoff)
		{
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x3246FD0", Offset = "0x32455D0", VA = "0x183246FD0")]
		private void _countGoWithlayer(string layerName)
		{
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x3247220", Offset = "0x3245820", VA = "0x183247220")]
		private void _listGoWithlayer(string layerName)
		{
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x3247580", Offset = "0x3245B80", VA = "0x183247580")]
		public static bool TryRunDynamicCommand(string command, string args, DebugConsole console)
		{
			return default(bool);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x3247850", Offset = "0x3245E50", VA = "0x183247850")]
		public static void RegisterCommand(string command, Func<string, bool> commandAction, object sender)
		{
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x3247B80", Offset = "0x3246180", VA = "0x183247B80")]
		public static void RegisterCommand(string command, Func<string, IEnumerator> commandAction, object sender)
		{
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x3247EB0", Offset = "0x32464B0", VA = "0x183247EB0")]
		public static void UnregisterCommand(string command, object sender)
		{
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000071E8 File Offset: 0x000053E8
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x3247FC0", Offset = "0x32465C0", VA = "0x183247FC0")]
		private static bool TryGetDynamicCommands(string lowerCommand, out Dictionary<object, DynamicCommand> dynamicCommands)
		{
			return default(bool);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x3248050", Offset = "0x3246650", VA = "0x183248050")]
		public static void RegisterBoolCommand(string command, Action<bool> commandAction, object sender)
		{
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x3248180", Offset = "0x3246780", VA = "0x183248180")]
		private void _regrowAllTrees(string arg)
		{
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x32481E0", Offset = "0x32467E0", VA = "0x1832481E0")]
		private void _restoreAllWorldLocators(string arg)
		{
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x32482A0", Offset = "0x32468A0", VA = "0x1832482A0")]
		private void _timeOfDayDebug(string arg)
		{
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x3248350", Offset = "0x3246950", VA = "0x183248350")]
		private void _billboardIgnoreChanges(string arg)
		{
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x3248400", Offset = "0x3246A00", VA = "0x183248400")]
		private void _treeOcclusionBonus(string arg)
		{
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x32484B0", Offset = "0x3246AB0", VA = "0x1832484B0")]
		private void _spawnFallingTree(string arg)
		{
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x3248500", Offset = "0x3246B00", VA = "0x183248500")]
		private void _billboardEnabled(string args)
		{
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x32487F0", Offset = "0x3246DF0", VA = "0x1832487F0")]
		private void _anisoEnabled(string arg)
		{
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x3248970", Offset = "0x3246F70", VA = "0x183248970")]
		private void _anisoMinMax(string arg)
		{
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00007200 File Offset: 0x00005400
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x3248A80", Offset = "0x3247080", VA = "0x183248A80")]
		private bool TryParseMinMaxString(string argString, out float minFloat, out float maxFloat)
		{
			return default(bool);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x3248C90", Offset = "0x3247290", VA = "0x183248C90")]
		private void _treeCutSimulateBolt(string arg)
		{
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AD")]
		[Address(RVA = "0x3248D40", Offset = "0x3247340", VA = "0x183248D40")]
		private void _treeFallContactInfo(string args)
		{
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AE")]
		[Address(RVA = "0x3248DF0", Offset = "0x32473F0", VA = "0x183248DF0")]
		private void _setWorldObjectStateRange(string args)
		{
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AF")]
		[Address(RVA = "0x3249440", Offset = "0x3247A40", VA = "0x183249440")]
		private void _breakObjects(string args)
		{
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x32497F0", Offset = "0x3247DF0", VA = "0x1832497F0")]
		private static void CutTreesInRange(string filter, float range, out int count)
		{
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x3249CE0", Offset = "0x32482E0", VA = "0x183249CE0")]
		private static void BreakObjectsInRange(string filter, float range, out int count)
		{
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x324A220", Offset = "0x3248820", VA = "0x18324A220")]
		private void _diggingClear(string value)
		{
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x324A550", Offset = "0x3248B50", VA = "0x18324A550")]
		private void _treesCutAll(string value)
		{
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x324A710", Offset = "0x3248D10", VA = "0x18324A710")]
		private void _clearBushRadius(string param)
		{
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B5")]
		[Address(RVA = "0x324A810", Offset = "0x3248E10", VA = "0x18324A810")]
		private void _treeRadius(string param)
		{
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x324AC90", Offset = "0x3249290", VA = "0x18324AC90")]
		private void _worldGroupId(string args)
		{
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x324B330", Offset = "0x3249930", VA = "0x18324B330")]
		private void _terrainTessDist(string args)
		{
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x324B4D0", Offset = "0x3249AD0", VA = "0x18324B4D0")]
		private void _exposureSetSpeed(string args)
		{
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B9")]
		[Address(RVA = "0x324B950", Offset = "0x3249F50", VA = "0x18324B950")]
		private void _terrainTess(string args)
		{
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BA")]
		[Address(RVA = "0x324BAE0", Offset = "0x324A0E0", VA = "0x18324BAE0")]
		private void _terrainParallax(string args)
		{
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BB")]
		[Address(RVA = "0x324BCB0", Offset = "0x324A2B0", VA = "0x18324BCB0")]
		private void SetTerrainTessValue(string args, string[] floatIds, string name, float defaultTerrainValue)
		{
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BC")]
		[Address(RVA = "0x324C0E0", Offset = "0x324A6E0", VA = "0x18324C0E0")]
		private void _showui(string onoff)
		{
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BD")]
		[Address(RVA = "0x324C190", Offset = "0x324A790", VA = "0x18324C190")]
		private void _showHud(string onoff)
		{
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x324C240", Offset = "0x324A840", VA = "0x18324C240")]
		private void _showInWorldUi(string onoff)
		{
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x324C2F0", Offset = "0x324A8F0", VA = "0x18324C2F0")]
		private void _rumbleTest(string args)
		{
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x324C340", Offset = "0x324A940", VA = "0x18324C340")]
		private IEnumerator RumbleTestWorker()
		{
			return null;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x324C380", Offset = "0x324A980", VA = "0x18324C380")]
		private void _invertLook(string param)
		{
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x324C430", Offset = "0x324AA30", VA = "0x18324C430")]
		private void _sprintToggle(string toggle)
		{
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x324C4E0", Offset = "0x324AAE0", VA = "0x18324C4E0")]
		private void _crouchToggle(string toggle)
		{
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x324C590", Offset = "0x324AB90", VA = "0x18324C590")]
		private void _setLookRotation(string rotation)
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x324C6D0", Offset = "0x324ACD0", VA = "0x18324C6D0")]
		private void _mouseXSensitivity(string value)
		{
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x324C7F0", Offset = "0x324ADF0", VA = "0x18324C7F0")]
		private void _mouseYSensitivity(string value)
		{
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x324C910", Offset = "0x324AF10", VA = "0x18324C910")]
		private void _gamePadXSensitivity(string value)
		{
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x324CA30", Offset = "0x324B030", VA = "0x18324CA30")]
		private void _gamePadYSensitivity(string value)
		{
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x324CB50", Offset = "0x324B150", VA = "0x18324CB50")]
		private void _gamePadDeadzone(string value)
		{
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x324CC70", Offset = "0x324B270", VA = "0x18324CC70")]
		private static void RunFloatMethod(string value, Action<float> action)
		{
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x324CD30", Offset = "0x324B330", VA = "0x18324CD30")]
		private void _spawnitem(string itemIdentifier)
		{
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x324D470", Offset = "0x324BA70", VA = "0x18324D470")]
		private void _refillContainers(string args)
		{
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x324D8B0", Offset = "0x324BEB0", VA = "0x18324D8B0")]
		private IEnumerator SpawnAllItems(int count)
		{
			return null;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x324D970", Offset = "0x324BF70", VA = "0x18324D970")]
		private void ShuffleItems(ref List<ItemData> allItemData)
		{
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x324DB20", Offset = "0x324C120", VA = "0x18324DB20")]
		private static IEnumerator SpawnItemInternal(ItemData itemData, int count)
		{
			return null;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x324DBE0", Offset = "0x324C1E0", VA = "0x18324DBE0")]
		private void _unloadScene(string levelArg)
		{
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x324DC60", Offset = "0x324C260", VA = "0x18324DC60")]
		private void _loadSceneSingle(string levelArg)
		{
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x324DCE0", Offset = "0x324C2E0", VA = "0x18324DCE0")]
		private void _loadScene(string levelArg)
		{
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00007218 File Offset: 0x00005418
		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x324DD60", Offset = "0x324C360", VA = "0x18324DD60")]
		private bool DoUnloadScene(string levelArg)
		{
			return default(bool);
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00007230 File Offset: 0x00005430
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x324E070", Offset = "0x324C670", VA = "0x18324E070")]
		private bool DoLoadScene(string levelArg, LoadSceneMode sceneMode)
		{
			return default(bool);
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x324E2E0", Offset = "0x324C8E0", VA = "0x18324E2E0")]
		private void _demoMode(string onoff)
		{
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x324E520", Offset = "0x324CB20", VA = "0x18324E520")]
		private void _combatTestStart(string param)
		{
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x324E680", Offset = "0x324CC80", VA = "0x18324E680")]
		private void CheckAutoRunMacros(object param)
		{
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x324E750", Offset = "0x324CD50", VA = "0x18324E750")]
		private void _loadMacros(string param)
		{
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x324EE00", Offset = "0x324D400", VA = "0x18324EE00")]
		private void _openmacrosfolder(string _)
		{
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x324F100", Offset = "0x324D700", VA = "0x18324F100")]
		private static string[] ParseMacroLines(string[] macroLines)
		{
			return null;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00007248 File Offset: 0x00005448
		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x324F210", Offset = "0x324D810", VA = "0x18324F210")]
		private static bool ValidMacroLine(string macroLine)
		{
			return default(bool);
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x324F290", Offset = "0x324D890", VA = "0x18324F290")]
		private static string ParseMacroName(string macroName)
		{
			return null;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x324F320", Offset = "0x324D920", VA = "0x18324F320")]
		private void _golfCartNetworkDebug(string arg)
		{
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x324F3D0", Offset = "0x324D9D0", VA = "0x18324F3D0")]
		private void _disconnectPlayer(string arg)
		{
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x324F6A0", Offset = "0x324DCA0", VA = "0x18324F6A0")]
		private static List<BoltConnection> GetConnections(List<BoltEntity> foundPlayers)
		{
			return null;
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x324FA60", Offset = "0x324E060", VA = "0x18324FA60")]
		private static List<BoltEntity> FindPlayers(string arg)
		{
			return null;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x324FCE0", Offset = "0x324E2E0", VA = "0x18324FCE0")]
		private void _disconnectPlayers(string arg)
		{
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x324FF70", Offset = "0x324E570", VA = "0x18324FF70")]
		private void _kickPlayers(string arg)
		{
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void _joinSteamLobby(string arg)
		{
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x3250200", Offset = "0x324E800", VA = "0x183250200")]
		private void ShowVailActorOverlay(VailOverlayType value, string filter)
		{
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x3250260", Offset = "0x324E860", VA = "0x183250260")]
		private void ShowVailRadar(VailRadarType value, string filter)
		{
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x32502C0", Offset = "0x324E8C0", VA = "0x1832502C0")]
		private void _showWorldObjects(string param)
		{
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x3250440", Offset = "0x324EA40", VA = "0x183250440")]
		private void _showObjectLocation(string objectName)
		{
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x3250620", Offset = "0x324EC20", VA = "0x183250620")]
		private void _showMeshObjectNames(string param)
		{
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x32507E0", Offset = "0x324EDE0", VA = "0x1832507E0")]
		private void _showActiveLights(string param)
		{
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x3250940", Offset = "0x324EF40", VA = "0x183250940")]
		private void _showCollisionObjectNames(string param)
		{
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x3250CE0", Offset = "0x324F2E0", VA = "0x183250CE0")]
		private void _showMeshTriangleCounts(string param)
		{
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x3250D90", Offset = "0x324F390", VA = "0x183250D90")]
		private void _showMeshMaterialNames(string param)
		{
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x3250E40", Offset = "0x324F440", VA = "0x183250E40")]
		private void _showTriggerCollision(string param)
		{
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x3250EF0", Offset = "0x324F4F0", VA = "0x183250EF0")]
		private void _showStimuli(string param)
		{
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00007260 File Offset: 0x00005460
		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x3251080", Offset = "0x324F680", VA = "0x183251080")]
		private bool IsAnyWorldOverlayActive()
		{
			return default(bool);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x32511C0", Offset = "0x324F7C0", VA = "0x1832511C0")]
		private void ShowWorldOverlays()
		{
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x32517C0", Offset = "0x324FDC0", VA = "0x1832517C0")]
		private void OnDebugOverlayGUI()
		{
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F2")]
		private void RefreshObjectsIfNeeded<T>(ref T[] compList, ref float refreshTime) where T : Component
		{
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x3251C60", Offset = "0x3250260", VA = "0x183251C60")]
		private void OnMeshNameOverlayGUI(Camera cam, Vector3 camPos, Vector3 camForward)
		{
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x3251EE0", Offset = "0x32504E0", VA = "0x183251EE0")]
		private void OnLightNameOverlayGUI(Camera cam, Vector3 camPos, Vector3 camForward)
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x3252150", Offset = "0x3250750", VA = "0x183252150")]
		private void OnCollisionNameOverlayGUI(Camera cam, Vector3 camPos, Vector3 camForward)
		{
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x32523C0", Offset = "0x32509C0", VA = "0x1832523C0")]
		private void ShowRendererLabel(Renderer meshRend, Camera cam, Vector3 camPos, Vector3 camForward, float maxDistSqr)
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x3252C70", Offset = "0x3251270", VA = "0x183252C70")]
		private void ShowColliderLabel(Collider col, Camera cam, Vector3 camPos, Vector3 camForward, float maxDistSqr)
		{
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x3253040", Offset = "0x3251640", VA = "0x183253040")]
		private string GetMaterialsLabel(Renderer eachMesh)
		{
			return null;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x32532C0", Offset = "0x32518C0", VA = "0x1832532C0")]
		private void ShowLightLabel(Light l, Camera cam, Vector3 camPos, Vector3 camForward, float maxDistSqr)
		{
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x3253710", Offset = "0x3251D10", VA = "0x183253710")]
		private void OnObjectLocatorOverlayGUI(Transform target, Camera cam, Vector3 camPos, Vector3 camForward)
		{
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x3253AF0", Offset = "0x32520F0", VA = "0x183253AF0")]
		private void _meshColliderMeshLog(string onoff)
		{
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x3253BA0", Offset = "0x32521A0", VA = "0x183253BA0")]
		private void _physicsUpdateTime(string onoff)
		{
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x3253E60", Offset = "0x3252460", VA = "0x183253E60")]
		private void _gravity(string value)
		{
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x32541F0", Offset = "0x32527F0", VA = "0x1832541F0")]
		private void _enableCollisionBasedKillBox(string onoff)
		{
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x3254370", Offset = "0x3252970", VA = "0x183254370")]
		private void _postProcessingComponent(string arg)
		{
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001700")]
		private static T SetVolumeComponent<T>(bool onSet) where T : VolumeComponent
		{
			return null;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x6001701")]
		private static bool TryGetPostComponent<T>(out T result) where T : VolumeComponent
		{
			return default(bool);
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001702")]
		[Address(RVA = "0x31199B0", Offset = "0x3117FB0", VA = "0x1831199B0")]
		private void _destroyRagdoll(string onoff)
		{
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001703")]
		[Address(RVA = "0x3254C30", Offset = "0x3253230", VA = "0x183254C30")]
		private void _save(string slotIndexArg)
		{
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001704")]
		[Address(RVA = "0x3254DB0", Offset = "0x32533B0", VA = "0x183254DB0")]
		private void _load(string slotIndexArg)
		{
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001705")]
		[Address(RVA = "0x3254F50", Offset = "0x3253550", VA = "0x183254F50")]
		private void _saveplayer(string arg)
		{
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001706")]
		[Address(RVA = "0x30E0C10", Offset = "0x30DF210", VA = "0x1830E0C10")]
		private void _loadplayer(string arg)
		{
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001707")]
		[Address(RVA = "0x3254F60", Offset = "0x3253560", VA = "0x183254F60")]
		private void _enableStructureGhosts(string onoff)
		{
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001708")]
		[Address(RVA = "0x3255010", Offset = "0x3253610", VA = "0x183255010")]
		private void _resetSettings(string args)
		{
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x6001709")]
		[Address(RVA = "0x3255050", Offset = "0x3253650", VA = "0x183255050")]
		private bool GetKeyAndValue(string args, string cmdDebugName, out string key, out string val)
		{
			return default(bool);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170A")]
		[Address(RVA = "0x3255380", Offset = "0x3253980", VA = "0x183255380")]
		private void _setSetting(string args)
		{
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170B")]
		[Address(RVA = "0x3256150", Offset = "0x3254750", VA = "0x183256150")]
		private void _setGameSetupSetting(string args)
		{
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170C")]
		[Address(RVA = "0x3257210", Offset = "0x3255810", VA = "0x183257210")]
		private void _qualityTexture(string args)
		{
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170D")]
		[Address(RVA = "0x3257450", Offset = "0x3255A50", VA = "0x183257450")]
		private void _mipmapStreaming(string onOff)
		{
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170E")]
		[Address(RVA = "0x3257500", Offset = "0x3255B00", VA = "0x183257500")]
		private void _mipmapStreamingBudget(string value)
		{
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170F")]
		[Address(RVA = "0x3257640", Offset = "0x3255C40", VA = "0x183257640")]
		private void _mipmapStreamingDiscard(string onOff)
		{
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001710")]
		[Address(RVA = "0x32576F0", Offset = "0x3255CF0", VA = "0x1832576F0")]
		private void SetTextureStreaming(bool value)
		{
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001711")]
		[Address(RVA = "0x3257760", Offset = "0x3255D60", VA = "0x183257760")]
		private void FlushStreamedMipMaps()
		{
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001712")]
		[Address(RVA = "0x3257820", Offset = "0x3255E20", VA = "0x183257820")]
		public void SetStreamingTextureDiscardUnusedMipsOff()
		{
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001713")]
		[Address(RVA = "0x3257830", Offset = "0x3255E30", VA = "0x183257830")]
		private void SetStreamingTextureDiscardUnusedMips(bool value)
		{
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001714")]
		[Address(RVA = "0x32578B0", Offset = "0x3255EB0", VA = "0x1832578B0")]
		private void _dumpTransformInfo(string filter)
		{
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x6001715")]
		[Address(RVA = "0x3258940", Offset = "0x3256F40", VA = "0x183258940")]
		private bool IsSafeVector3(Vector3 valueLocalPosition)
		{
			return default(bool);
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001716")]
		[Address(RVA = "0x32589E0", Offset = "0x3256FE0", VA = "0x1832589E0")]
		private void _sleepCooldown(string arg)
		{
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001717")]
		[Address(RVA = "0x3258A90", Offset = "0x3257090", VA = "0x183258A90")]
		private void _setOpeningCrash(string arg)
		{
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001718")]
		[Address(RVA = "0x3258B70", Offset = "0x3257170", VA = "0x183258B70")]
		private void _radioDebug(string arg)
		{
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001719")]
		[Address(RVA = "0x3258C20", Offset = "0x3257220", VA = "0x183258C20")]
		private void _blockPlayerFinalDeath(string arg)
		{
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171A")]
		[Address(RVA = "0x3258CD0", Offset = "0x32572D0", VA = "0x183258CD0")]
		private void _gameOverDelayTime(string arg)
		{
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171B")]
		[Address(RVA = "0x3258D80", Offset = "0x3257380", VA = "0x183258D80")]
		private void _instantRespawnHere(string param)
		{
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171C")]
		[Address(RVA = "0x3258E90", Offset = "0x3257490", VA = "0x183258E90")]
		private void _playerInterruptKeys(string arg)
		{
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171D")]
		[Address(RVA = "0x3258F40", Offset = "0x3257540", VA = "0x183258F40")]
		private void PlayerInterruptKeysOn(bool value)
		{
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600171E")]
		[Address(RVA = "0x3259160", Offset = "0x3257760", VA = "0x183259160")]
		private IEnumerator CheckPlayerInterruptKeys()
		{
			return null;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171F")]
		[Address(RVA = "0x32591F0", Offset = "0x32577F0", VA = "0x1832591F0")]
		private void _disableGameObjectTester(string args)
		{
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001720")]
		[Address(RVA = "0x325A420", Offset = "0x3258A20", VA = "0x18325A420")]
		private void _caveLight(string param)
		{
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001721")]
		[Address(RVA = "0x325A720", Offset = "0x3258D20", VA = "0x18325A720")]
		private void _timeOfDayConnectionDebug(string arg)
		{
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001722")]
		[Address(RVA = "0x325A7D0", Offset = "0x3258DD0", VA = "0x18325A7D0")]
		private void _lodForce3DDistance(string arg)
		{
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001723")]
		[Address(RVA = "0x325A880", Offset = "0x3258E80", VA = "0x18325A880")]
		private void _lodForce2DDistance(string arg)
		{
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001724")]
		[Address(RVA = "0x325A930", Offset = "0x3258F30", VA = "0x18325A930")]
		private void _lodDebugBillboards(string onOff)
		{
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001725")]
		[Address(RVA = "0x325A9E0", Offset = "0x3258FE0", VA = "0x18325A9E0")]
		private void _forceRemoveTrees(string countStr)
		{
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001726")]
		[Address(RVA = "0x325AC30", Offset = "0x3259230", VA = "0x18325AC30")]
		private void SetDebugBillboards(bool value)
		{
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001727")]
		[Address(RVA = "0x325ACF0", Offset = "0x32592F0", VA = "0x18325ACF0")]
		private void _lodDebugMaterials(string onOff)
		{
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001728")]
		[Address(RVA = "0x325ADA0", Offset = "0x32593A0", VA = "0x18325ADA0")]
		private void _applyDefaultMaterials(string onOff)
		{
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x6001729")]
		[Address(RVA = "0x325AE50", Offset = "0x3259450", VA = "0x18325AE50")]
		private bool StopApplyMaterial()
		{
			return default(bool);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172A")]
		[Address(RVA = "0x325AF80", Offset = "0x3259580", VA = "0x18325AF80")]
		private void _firstLookForce(string onoff)
		{
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172B")]
		[Address(RVA = "0x325B030", Offset = "0x3259630", VA = "0x18325B030")]
		private void _showButterflyInfo(string onOff)
		{
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172C")]
		[Address(RVA = "0x325B0E0", Offset = "0x32596E0", VA = "0x18325B0E0")]
		private void _dynamicResolutionCycleTest(string arg)
		{
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172D")]
		[Address(RVA = "0x325B230", Offset = "0x3259830", VA = "0x18325B230")]
		private IEnumerator DynamicResolutionTestWorker()
		{
			return null;
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x325B270", Offset = "0x3259870", VA = "0x18325B270")]
		private void _dynamicResolutionOverride(string arg)
		{
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x325B420", Offset = "0x3259A20", VA = "0x18325B420")]
		private void _dynamicResolutionTarget(string arg)
		{
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x325B5B0", Offset = "0x3259BB0", VA = "0x18325B5B0")]
		private void _findObjectsWithShader(string shaderName)
		{
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x325B9E0", Offset = "0x3259FE0", VA = "0x18325B9E0")]
		private void _removeShader(string shaderName)
		{
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001732")]
		[Address(RVA = "0x325BBF0", Offset = "0x325A1F0", VA = "0x18325BBF0")]
		private void _replaceShader(string shaderName)
		{
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x325BE80", Offset = "0x325A480", VA = "0x18325BE80")]
		private IEnumerator ApplyShaderToMaterialsWorker(string shaderPath, bool addRandomColor)
		{
			return null;
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001734")]
		[Address(RVA = "0x325BF90", Offset = "0x325A590", VA = "0x18325BF90")]
		private void _lodDebugRanges(string lodType)
		{
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x325C5F0", Offset = "0x325ABF0", VA = "0x18325C5F0")]
		private void _createLight(string args)
		{
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001736")]
		[Address(RVA = "0x325C900", Offset = "0x325AF00", VA = "0x18325C900")]
		private void _duplicateObject(string args)
		{
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001737")]
		[Address(RVA = "0x325D070", Offset = "0x325B670", VA = "0x18325D070")]
		private void _setProperty(string args)
		{
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001738")]
		[Address(RVA = "0x325D9A0", Offset = "0x325BFA0", VA = "0x18325D9A0")]
		private static string[] ProcessArgs(string args)
		{
			return null;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001739")]
		[Address(RVA = "0x325DC10", Offset = "0x325C210", VA = "0x18325DC10")]
		private GameObject CreateCaveLight()
		{
			return null;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173A")]
		[Address(RVA = "0x325E0D0", Offset = "0x325C6D0", VA = "0x18325E0D0")]
		public DebugConsole()
		{
		}

		// Token: 0x040015E8 RID: 5608
		[Token(Token = "0x40015E8")]
		private const int TrackSuitId = 555;

		// Token: 0x040015E9 RID: 5609
		[Token(Token = "0x40015E9")]
		private const int DressId = 556;

		// Token: 0x040015EA RID: 5610
		[Token(Token = "0x40015EA")]
		private const int LeatherSuitId = 557;

		// Token: 0x040015EB RID: 5611
		[Token(Token = "0x40015EB")]
		private const int CamoSuitId = 558;

		// Token: 0x040015EC RID: 5612
		[Token(Token = "0x40015EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _debugAudioEvent;

		// Token: 0x040015ED RID: 5613
		[Token(Token = "0x40015ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<string[]> _audioParameters;

		// Token: 0x040015EE RID: 5614
		[Token(Token = "0x40015EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _2dAudioTestListener;

		// Token: 0x040015EF RID: 5615
		[Token(Token = "0x40015EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _defaultFov;

		// Token: 0x040015F0 RID: 5616
		[Token(Token = "0x40015F0")]
		private const string RegexWhiteSpace = "\\s";

		// Token: 0x040015F1 RID: 5617
		[Token(Token = "0x40015F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _historyEnd;

		// Token: 0x040015F2 RID: 5618
		[Token(Token = "0x40015F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _historyCurrent;

		// Token: 0x040015F3 RID: 5619
		[Token(Token = "0x40015F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _consoleInput;

		// Token: 0x040015F4 RID: 5620
		[Token(Token = "0x40015F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string _autocomplete;

		// Token: 0x040015F5 RID: 5621
		[Token(Token = "0x40015F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool _showOverlay;

		// Token: 0x040015F6 RID: 5622
		[Token(Token = "0x40015F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool _showLog;

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _logCanvas;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _logMessage;

		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<GameObject> _logMessageInstances;

		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool _showConsole;

		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool _showGamePadWheel;

		// Token: 0x040015FC RID: 5628
		[Token(Token = "0x40015FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool _showPlayerStats;

		// Token: 0x040015FD RID: 5629
		[Token(Token = "0x40015FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		public bool _showFramerate;

		// Token: 0x040015FE RID: 5630
		[Token(Token = "0x40015FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool _showPlayerVisibility;

		// Token: 0x040015FF RID: 5631
		[Token(Token = "0x40015FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GUIStyle _consoleRowStyle;

		// Token: 0x04001600 RID: 5632
		[Token(Token = "0x4001600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GUIStyle _logRowStyle;

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GUIStyle _textStyle;

		// Token: 0x04001602 RID: 5634
		[Token(Token = "0x4001602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<GameObject> _activateObjects;

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _warningTextColor;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _errorTextColor;

		// Token: 0x04001605 RID: 5637
		[Token(Token = "0x4001605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Color _exceptionTextColor;

		// Token: 0x04001606 RID: 5638
		[Token(Token = "0x4001606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Multiline]
		public string _reportFormat;

		// Token: 0x04001607 RID: 5639
		[Token(Token = "0x4001607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string _reportFormatNew;

		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public string _reportUrl;

		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int BatchedTasksNear;

		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int BatchedTasksFar;

		// Token: 0x0400160B RID: 5643
		[Token(Token = "0x400160B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Queue<LogContent> _logs;

		// Token: 0x0400160C RID: 5644
		[Token(Token = "0x400160C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private LogContent _lastLog;

		// Token: 0x0400160D RID: 5645
		[Token(Token = "0x400160D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private DebugConsoleRoutine _routineMB;

		// Token: 0x0400160E RID: 5646
		[Token(Token = "0x400160E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Coroutine _inputRoutine;

		// Token: 0x0400160F RID: 5647
		[Token(Token = "0x400160F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool _destroyOnTitleSceneLoad;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private int _maxLogs;

		// Token: 0x04001611 RID: 5649
		[Token(Token = "0x4001611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector2 _logsScrollPos;

		// Token: 0x04001612 RID: 5650
		[Token(Token = "0x4001612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private string[] _history;

		// Token: 0x04001613 RID: 5651
		[Token(Token = "0x4001613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private char[] _alphaNum;

		// Token: 0x04001614 RID: 5652
		[Token(Token = "0x4001614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _fps;

		// Token: 0x04001615 RID: 5653
		[Token(Token = "0x4001615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private bool _showWSDetail;

		// Token: 0x04001616 RID: 5654
		[Token(Token = "0x4001616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
		private bool _focusConsoleField;

		// Token: 0x04001617 RID: 5655
		[Token(Token = "0x4001617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12E")]
		private bool _selectConsoleText;

		// Token: 0x04001618 RID: 5656
		[Token(Token = "0x4001618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Dictionary<string, MethodInfo> _availableConsoleMethods;

		// Token: 0x04001619 RID: 5657
		[Token(Token = "0x4001619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Dictionary<Type, int> _counters;

		// Token: 0x0400161A RID: 5658
		[Token(Token = "0x400161A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Dictionary<string, string> _gamepadWheelEntries;

		// Token: 0x0400161B RID: 5659
		[Token(Token = "0x400161B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, int> Counters;

		// Token: 0x0400161C RID: 5660
		[Token(Token = "0x400161C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DebugConsole Instance;

		// Token: 0x0400161D RID: 5661
		[Token(Token = "0x400161D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Transform lastLocalTarget;

		// Token: 0x0400161E RID: 5662
		[Token(Token = "0x400161E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private int _totalEntities;

		// Token: 0x0400161F RID: 5663
		[Token(Token = "0x400161F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private int _activeEntities;

		// Token: 0x04001620 RID: 5664
		[Token(Token = "0x4001620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private int _overlayState;

		// Token: 0x04001621 RID: 5665
		[Token(Token = "0x4001621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private VisualWorldDebugGrid _visualWorldDebugGrid;

		// Token: 0x04001622 RID: 5666
		[Token(Token = "0x4001622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool _showWarnSetting;

		// Token: 0x04001623 RID: 5667
		[Token(Token = "0x4001623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool _showInfoSetting;

		// Token: 0x04001624 RID: 5668
		[Token(Token = "0x4001624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A")]
		private bool _showErrorSetting;

		// Token: 0x04001625 RID: 5669
		[Token(Token = "0x4001625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int _logCallbackCount;

		// Token: 0x04001626 RID: 5670
		[Token(Token = "0x4001626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private int _lastLogCallbackCountHandled;

		// Token: 0x04001627 RID: 5671
		[Token(Token = "0x4001627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private List<string> _commandShortList;

		// Token: 0x04001628 RID: 5672
		[Token(Token = "0x4001628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool _blockConsole;

		// Token: 0x04001629 RID: 5673
		[Token(Token = "0x4001629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private List<GameObject> _disabledGOs;

		// Token: 0x0400162A RID: 5674
		[Token(Token = "0x400162A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool _speedyRunIsActive;

		// Token: 0x0400162B RID: 5675
		[Token(Token = "0x400162B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private float _speedyRunMultipler;

		// Token: 0x0400162C RID: 5676
		[Token(Token = "0x400162C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private Coroutine _followCoroutine;

		// Token: 0x0400162D RID: 5677
		[Token(Token = "0x400162D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private GUIStyle _style;

		// Token: 0x0400162E RID: 5678
		[Token(Token = "0x400162E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Dictionary<string, Vector3> _loadedGotos;

		// Token: 0x0400162F RID: 5679
		[Token(Token = "0x400162F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Vector3 _defaultGravity;

		// Token: 0x04001630 RID: 5680
		[Token(Token = "0x4001630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool _cursorAtEndConsoleInput;

		// Token: 0x04001631 RID: 5681
		[Token(Token = "0x4001631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Material _terrainDefaultMaterial;

		// Token: 0x04001632 RID: 5682
		[Token(Token = "0x4001632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Material _terrainSimpleMaterial;

		// Token: 0x04001633 RID: 5683
		[Token(Token = "0x4001633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private float wsMaxMsValue;

		// Token: 0x04001634 RID: 5684
		[Token(Token = "0x4001634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<string, Dictionary<object, DynamicCommand>> _dynamicCommands;

		// Token: 0x04001635 RID: 5685
		[Token(Token = "0x4001635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private int _defaultTerrainTess;

		// Token: 0x04001636 RID: 5686
		[Token(Token = "0x4001636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private float _defaultTerrainTessDist;

		// Token: 0x04001637 RID: 5687
		[Token(Token = "0x4001637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string _macrosDir;

		// Token: 0x04001638 RID: 5688
		[Token(Token = "0x4001638")]
		private const string AutoRunMacroSettingKey = "AutoRunMacro";

		// Token: 0x04001639 RID: 5689
		[Token(Token = "0x4001639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float _showMeshOverlayDist;

		// Token: 0x0400163A RID: 5690
		[Token(Token = "0x400163A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float _showMeshMinSize;

		// Token: 0x0400163B RID: 5691
		[Token(Token = "0x400163B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private string _showMeshFilter;

		// Token: 0x0400163C RID: 5692
		[Token(Token = "0x400163C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool _showMeshMaterials;

		// Token: 0x0400163D RID: 5693
		[Token(Token = "0x400163D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
		private bool _showMeshTriCount;

		// Token: 0x0400163E RID: 5694
		[Token(Token = "0x400163E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F2")]
		private bool _showTriggerCollisionOn;

		// Token: 0x0400163F RID: 5695
		[Token(Token = "0x400163F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Renderer[] _meshes;

		// Token: 0x04001640 RID: 5696
		[Token(Token = "0x4001640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private float _refreshMeshTime;

		// Token: 0x04001641 RID: 5697
		[Token(Token = "0x4001641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float _showColliderOverlayDist;

		// Token: 0x04001642 RID: 5698
		[Token(Token = "0x4001642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private string _showCollisionFilter;

		// Token: 0x04001643 RID: 5699
		[Token(Token = "0x4001643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Collider[] _colliders;

		// Token: 0x04001644 RID: 5700
		[Token(Token = "0x4001644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private float _refreshColliderTime;

		// Token: 0x04001645 RID: 5701
		[Token(Token = "0x4001645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private bool _showCollisionLayers;

		// Token: 0x04001646 RID: 5702
		[Token(Token = "0x4001646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21D")]
		private bool _showCollisionTags;

		// Token: 0x04001647 RID: 5703
		[Token(Token = "0x4001647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21E")]
		private bool _showLightsOverlay;

		// Token: 0x04001648 RID: 5704
		[Token(Token = "0x4001648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private float _refreshLightTime;

		// Token: 0x04001649 RID: 5705
		[Token(Token = "0x4001649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Light[] _lights;

		// Token: 0x0400164A RID: 5706
		[Token(Token = "0x400164A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private GameObject _objectLocationTarget;

		// Token: 0x0400164B RID: 5707
		[Token(Token = "0x400164B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private int _showStimuliDist;

		// Token: 0x0400164C RID: 5708
		[Token(Token = "0x400164C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private string _stimuliTypeFilter;

		// Token: 0x0400164D RID: 5709
		[Token(Token = "0x400164D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private VailOverlayType _showVailActorOverlay;

		// Token: 0x0400164E RID: 5710
		[Token(Token = "0x400164E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private string _showVailOverlayTypeFilter;

		// Token: 0x0400164F RID: 5711
		[Token(Token = "0x400164F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private VailRadarType _showVailRadar;

		// Token: 0x04001650 RID: 5712
		[Token(Token = "0x4001650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private string _radarTypeFilter;

		// Token: 0x04001651 RID: 5713
		[Token(Token = "0x4001651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private int _showWorldObjectOverlayDist;

		// Token: 0x04001652 RID: 5714
		[Token(Token = "0x4001652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private string _worldObjectFilter;

		// Token: 0x04001653 RID: 5715
		[Token(Token = "0x4001653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private float _defaultFixedDeltaTime;

		// Token: 0x04001654 RID: 5716
		[Token(Token = "0x4001654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private Coroutine _dynamicResolutionTestWorker;

		// Token: 0x04001655 RID: 5717
		[Token(Token = "0x4001655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private GameObject _caveLightGo;

		// Token: 0x04001656 RID: 5718
		[Token(Token = "0x4001656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int BaseColorIndex;

		// Token: 0x04001657 RID: 5719
		[Token(Token = "0x4001657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private Coroutine _applyMaterialsWorker;

		// Token: 0x04001658 RID: 5720
		[Token(Token = "0x4001658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private string _replaceShaderString;

		// Token: 0x04001659 RID: 5721
		[Token(Token = "0x4001659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private List<Shader> _replacedShaders;

		// Token: 0x0400165A RID: 5722
		[Token(Token = "0x400165A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private int _spawnedLights;

		// Token: 0x0400165B RID: 5723
		[Token(Token = "0x400165B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private bool _playerInterruptKeysOn;

		// Token: 0x0400165C RID: 5724
		[Token(Token = "0x400165C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private Coroutine _checkPlayerInterruptKeysRoutine;

		// Token: 0x02000358 RID: 856
		[Token(Token = "0x2000358")]
		internal class DebugConsoleMacro
		{
			// Token: 0x06001743 RID: 5955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001743")]
			[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
			internal DebugConsoleMacro(string name, string[] commands)
			{
			}

			// Token: 0x06001744 RID: 5956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001744")]
			[Address(RVA = "0x326FE80", Offset = "0x326E480", VA = "0x18326FE80")]
			public IEnumerator Execute(string param)
			{
				return null;
			}

			// Token: 0x06001745 RID: 5957 RVA: 0x000072D8 File Offset: 0x000054D8
			[Token(Token = "0x6001745")]
			[Address(RVA = "0x326FF10", Offset = "0x326E510", VA = "0x18326FF10")]
			private bool TryGetSleepTimer(string command, out float result)
			{
				return default(bool);
			}

			// Token: 0x06001746 RID: 5958 RVA: 0x000072F0 File Offset: 0x000054F0
			[Token(Token = "0x6001746")]
			[Address(RVA = "0x32701C0", Offset = "0x326E7C0", VA = "0x1832701C0")]
			private static bool ProcessFloatParts(out float result, string integer, string decimalPoint, string remainder)
			{
				return default(bool);
			}

			// Token: 0x0400165D RID: 5725
			[Token(Token = "0x400165D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string _name;

			// Token: 0x0400165E RID: 5726
			[Token(Token = "0x400165E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string[] _commands;
		}
	}
}
