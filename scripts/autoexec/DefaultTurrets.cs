// DefaultTurrets.cs
// Restore Default Turret count at the end of the match + MPB
// Some maps in this map use non-default turret numbers

$DMP::indoorMinDef  = $TeamDeployableMin[TurretIndoorDeployable];
$DMP::outdoorMinDef = $TeamDeployableMin[TurretOutdoorDeployable];
$DMP::indoorMaxDef  = $TeamDeployableMax[TurretIndoorDeployable];
$DMP::outdoorMaxDef = $TeamDeployableMax[TurretOutdoorDeployable];

$DMP::vehicleMPBMax = $VehicleMax[MobileBaseVehicle];

package turretDefaults
{
	
function DefaultGame::gameOver( %game )
{
	parent::gameOver(%game);

	$TeamDeployableMin[TurretIndoorDeployable]  = $DMP::indoorMinDef;
	$TeamDeployableMin[TurretOutdoorDeployable] = $DMP::outdoorMinDef;
	$TeamDeployableMax[TurretIndoorDeployable]  = $DMP::indoorMaxDef;
	$TeamDeployableMax[TurretOutdoorDeployable] = $DMP::outdoorMaxDef;
	
	$VehicleMax[MobileBaseVehicle] = $DMP::vehicleMPBMax;
}

};

if(!isActivePackage(turretDefaults))
   activatePackage(turretDefaults);