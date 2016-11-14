from subprocess import call
from glob import glob
from os.path import dirname, abspath
from datetime import datetime
from uuid import uuid4

here = dirname(abspath(__file__))

for i in range(1000):
    for img in glob(abspath(here + '/images/*.*')):
        target = '{:%Y%m%d%H%M%S%f}-{}.jpg'.format(datetime.now(), uuid4())
        call(['azure', 'storage', 'blob', 'upload', img, 'sample-images', target])
