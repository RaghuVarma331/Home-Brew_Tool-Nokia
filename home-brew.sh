#!/bin/bash
#
# RAGHU VARMA Home Brew Tool Script 
# Coded by RV 
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

clear

Telegram_Api_code=
url=https://android.googleapis.com/packages/ota-api/nokia_drgsprout_dragon00ww/810351d123009ec07c1cb5857c4707fdeba776ef.zip
path=/root
device=DRG
buildnumber=354H
androidversion=9.0
password=

echo "-----------------------------------------------------------"
echo "A simple tool to make home brew stock rom from Full OTA.zip"
echo "Coded By Raghu Varma.G "
echo "-----------------------------------------------------------"
mkdir stock
cd stock
wget $url
unzip *
mkdir payload
mkdir output
cp -r payload.bin $path/stock/payload
cd payload
wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/payload_dumper.py
wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/update_metadata_pb2.py
wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/img2simg
wget https://github.com/RaghuVarma331/Home-Brew_Tool-Nokia/raw/master/simg2img
chmod a+x payload_dumper.py
chmod a+x update_metadata_pb2.py
chmod a+x simg2img
chmod a+x img2simg
./payload_dumper.py payload.bin 
mv abl.img          $device-$buildnumber-0-00WW-B01-abl.img
mv bluetooth.img    $device-$buildnumber-0-00WW-B01-bluetooth.img
mv boot.img         $device-$buildnumber-0-00WW-B01-boot.img
mv cda.img          $device-$buildnumber-0-00WW-B01-cda.img
mv cmnlib.img       $device-$buildnumber-0-00WW-B01-cmnlib.img
mv cmnlib64.img     $device-$buildnumber-0-00WW-B01-cmnlib64.img
mv devcfg.img       $device-$buildnumber-0-00WW-B01-devcfg.img
mv dsp.img          $device-$buildnumber-0-00WW-B01-dsp.img
mv hidden.img       $device-$buildnumber-0-00WW-B01-hidden.img
mv hyp.img          $device-$buildnumber-0-00WW-B01-hyp.img
mv keymaster.img    $device-$buildnumber-0-00WW-B01-keymaster.img
mv mdtp.img         $device-$buildnumber-0-00WW-B01-mdtp.img
mv mdtpsecapp.img   $device-$buildnumber-0-00WW-B01-mdtpsecapp.img
mv modem.img        $device-$buildnumber-0-00WW-B01-modem.img
mv nvdef.img        $device-$buildnumber-0-00WW-B01-nvdef.img
mv pmic.img         $device-$buildnumber-0-00WW-B01-pmic.img
mv rpm.img          $device-$buildnumber-0-00WW-B01-rpm.img
mv splash.img       $device-$buildnumber-0-00WW-B01-splash.img
mv systeminfo.img   $device-$buildnumber-0-00WW-B01-systeminfo.img
mv tz.img           $device-$buildnumber-0-00WW-B01-tz.img
mv xbl.img          $device-$buildnumber-0-00WW-B01-xbl.img
./img2simg system.img $device-$buildnumber-0-00WW-B01-system.img
./img2simg vendor.img $device-$buildnumber-0-00WW-B01-vendor.img
rm -r payload.bin payload_dumper.py update_metadata_pb2.py update_metadata_pb2.pyc simg2img img2simg vendor.img system.img 
zip -r $device-$buildnumber-0-00WW-B01-$androidversion.zip *
cp -r $device-$buildnumber-0-00WW-B01-$androidversion.zip $path/stock/output
cd
cd $path/stock/output
sshpass -p $password rsync -avP -e ssh DRG-$buildnumber-0-00WW-B01-$androidversion.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/drg-sprout/STOCK-ROMS
sshpass -p $password rsync -avP -e ssh B2N-$buildnumber-0-00WW-B01-$androidversion.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/b2n-sprout/STOCK-ROMS
sshpass -p $password rsync -avP -e ssh CTL-$buildnumber-0-00WW-B01-$androidversion.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/ctl-sprout/STOCK-ROMS
sshpass -p $password rsync -avP -e ssh PL2-$buildnumber-0-00WW-B01-$androidversion.zip raghuvarma331@frs.sourceforge.net:/home/frs/project/pl2-sprout/STOCK-ROMS
wget https://github.com/RaghuVarma331/scripts/raw/master/telegram.py
wget https://github.com/RaghuVarma331/custom_roms_banners/raw/master/image.png
python telegram.py -t $Telegram_Api_code -c @Nokia6plusofficial -P image.png -C " 
*
New Home Brew Stock Rom 
Release is Up
$(date)*
⬇️ [Download](https://sourceforge.net/projects/drg-sprout/files/STOCK-ROMS)
💬 [Flashing procedure](https://raw.githubusercontent.com/RaghuVarma331/changelogs/master/crossdevelopment/installation.txt)
📱 Device: *Nokia 6.1 Plus*
⚡Build Version: *$device-$buildnumber-0-00WW-B01-$androidversion.zip*
⚡Android Version: *$androidversion*
⚡Google Security Patch : *$securitypatch*
👤 By: *Raghu Varma*
#OTA #NOKIA #UPDATE #PATCH                                                                                                                                                                          
Follow: @Nokia6plusofficial ✅" 
echo "------------------------------------------------------------------------------"
echo " build is in                                                                  "
echo " $path/stock/output/$device-$buildnumber-0-00WW-B01-$androidversion.zip       "
echo "------------------------------------------------------------------------------"
